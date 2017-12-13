using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    class ProfileRepsitory
    {
        private List<Profile> profiles = new List<Profile>();

        public void CreateNewProfile(string profileName, string profileEmail = null, string profileSchoolOrCompany = null, string profileTelephone = null)
        {
            Profile newProfile = new Profile(profileName, profileEmail, profileSchoolOrCompany, profileTelephone);

            profiles.Add(newProfile);
        }
    }
}
