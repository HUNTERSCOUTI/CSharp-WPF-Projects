using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.UserSystem
{
    public class User
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        [Key]
        public Guid Id { get; set; } // Globally Unique Identifier

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
