using System.Collections.Generic;

namespace Laboratorio1.Model
{
    class User
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public static List<User> users = new List<User>();

    }
}
