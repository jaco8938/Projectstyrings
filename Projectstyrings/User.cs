using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string tlf { get; set; }

        public User(string playerName, string playerAddress = null, string playerEmail = null, string playerTelephone = null)
        {
            name = UserName;
            password = UserPassword;
            email = playerEmail;
            tlf = playerTelephone;
        }
    }
}