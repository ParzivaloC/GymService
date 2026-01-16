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
            return File.Exists(GetPath());
        }

        public static User? LoadUser()
        {
            var path = GetPath();
            if (!File.Exists(path)) return null;
            var txt = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<User>(txt);
        }

        public static void SaveUser(User user)
        {
            var path = GetPath();
            var txt = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText(path, txt);
        }

        public static void DeleteUser()
        {
            var path = GetPath();
            if (File.Exists(path)) File.Delete(path);
        }
    }
}
