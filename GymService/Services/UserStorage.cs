using System;
using System.IO;
using Newtonsoft.Json;
using GymService.Models;

namespace GymService.Services
{
    public static class UserStorage
    {
        private static string GetPath()
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GymService");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            return Path.Combine(dir, "user.json");
        }

        public static bool IsUserExists()
        {
            try
            {
                return File.Exists(GetPath());
            }
            catch
            {
                return false;
            }
        }

        public static User? LoadUser()
        {
            var path = GetPath();
            if (!File.Exists(path)) return null;

            try
            {
                var txt = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<User>(txt);
            }
            catch (JsonException)
            {
                // corrupted json
                return null;
            }
            catch (IOException)
            {
                return null;
            }
            catch
            {
                return null;
            }
        }

        public static bool SaveUser(User user)
        {
            var path = GetPath();
            try
            {
                var txt = JsonConvert.SerializeObject(user, Formatting.Indented);
                var tmp = path + ".tmp";
                File.WriteAllText(tmp, txt);
                // replace existing file atomically where possible
                File.Copy(tmp, path, true);
                File.Delete(tmp);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteUser()
        {
            var path = GetPath();
            try
            {
                if (File.Exists(path)) File.Delete(path);
            }
            catch
            {
                // ignore
            }
        }
    }
}
