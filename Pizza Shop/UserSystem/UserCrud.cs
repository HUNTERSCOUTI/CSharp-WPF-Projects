using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Pizza_Shop.UserSystem
{
    public static class UserCrud // User Create Reade Update Delete
    {
        public static List<User> Users = new();

        public static void LoadJson()
        {
            string fileName = @"C:\Users\LenovoThinkpad\source\repos\CSharp-WPF-Projects\Pizza Shop\UserSystem\Users.json";

            
        }

        public static void SaveNewUser(User newUser)
        {
            string fileName = @"C:\Users\LenovoThinkpad\source\repos\CSharp-WPF-Projects\Pizza Shop\UserSystem\Users.json";
            if (File.Exists(fileName))
            {
                string fileStr = File.ReadAllText(fileName);
                Users = JsonConvert.DeserializeObject<List<User>>(fileStr);
            }
            newUser.Id = Guid.NewGuid();
            Users.Add(newUser);

            var jsonSerialized = JsonConvert.SerializeObject(Users);
            File.WriteAllText(fileName, jsonSerialized);
        }

        public static bool UserExists(string username, string password)
        {
            //Will check if both password and username already exists
            bool userfound = Users.Any(user => user.Username == username && user.Password == password);

            if (userfound)
            {
                return true;
            }

            return false;

        }
    }
}
