using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectstyrings.Data_Access_Layer;

namespace Projectstyrings
{
    class ProfileRepository
    {
        private List<Profile> profiles = new List<Profile>();
        
        public ProfileRepository()
        {
            Database_Access DB = new Database_Access();
            profiles = DB.GetProfiles();
        }
        public List<Profile> GetProfiles()
        {
            return profiles;
        }

        public void CreateNewProfile(int id, string profileName, string profileTelephone = null, string profileEmail = null, string profileSchoolOrCompany = null)
        {
            Profile newProfile = new Profile(id, profileName, profileTelephone, profileEmail, profileSchoolOrCompany);

            profiles.Add(newProfile);
        }
    }
}
