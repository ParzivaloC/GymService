using System;
using System.IO;
using System.Text.Json;
using GymService.Models;

namespace GymService.Services
{
    public static class UserStorage
    {
        private const string FileName = "user.json";

        public static bool UserExists()
        {
            return File.Exists(FileName);
        }

        public static User? LoadUser()
        {
            if (!File.Exists(FileName))
                return null;

            try
            {
                string json = File.ReadAllText(FileName);
                return JsonSerializer.Deserialize<User>(json);
            }
            catch
            {
                return null;
            }
        }

        public static bool SaveUser(User user)
        {
            try
            {
                string json = JsonSerializer.Serialize(user, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(FileName, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteUser()
        {
            if (File.Exists(FileName))
                File.Delete(FileName);
        }
    }
}
