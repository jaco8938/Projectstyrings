using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    class UserRepo
    {
        private List<User> players = new List<User>();

        public void RegisterPlayer(User user)
        {
            players.Add(user);
        }

        public void RegisterPlayer(string name, string password = null, string email = null, string telephone = null)
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
                if (players[idx].name.Equals(name))
                {
                    foundUser = users[idx];
                }
                idx++;
            }
            return foundUser;
        }
    }
}
