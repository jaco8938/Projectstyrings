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
        public string companyOrSchool { get; set; }

        public User(string UserName, string UserPassword = null, string UserEmail = null, string UserTlf = null, string companySchool = null)
        {
            name = UserName;
            password = UserPassword;
            email = UserEmail;
            tlf = UserTlf;
            companyOrSchool = companySchool;
        }
    }
}