using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    static public class UserRepository
    {
        private static List<User> users = new List<User>();
        public static List<User> Users
        {
            get
            {
                return users;
            }
        }
        public static void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
