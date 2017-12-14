using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    class UserRepo
    {
        private List<User> users = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void RegisterUser(string name, string password = null, string email = null, string telephone = null)
        {
            User newUser = new User(name, password, email, telephone);
            RegisterUser(newUser);
        }

        public User GetUser(string name)
        {
            User foundUser = null;
            int idx = 0;
            while ((foundUser == null) && (idx < users.Count))
            {
                if (users[idx].name.Equals(name))
                {
                    foundUser = users[idx];
                }
                idx++;
            }
            return foundUser;
        }
    }
}
