using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string password { get; set; }
        public string Email { get; set; }
        public string SchoolOrCompany { get; set; }
        public string Tlf { get; set; }
        List<Project> projects = new List<Project>();

        public Profile(int id, string profileName, string profileTelephone = null, string profileEmail = null, string profileSchoolOrCompany = null)
        {
            Id = id;
            Name = profileName;
            //password = userPassword;
            Email = profileEmail;
            SchoolOrCompany = profileSchoolOrCompany;
            Tlf = profileTelephone;
        }

        public void AddProject(Project newProject)
        {
            projects.Add(newProject);
        }
    }
}