using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConnectToDB2017_C06;

namespace Projectstyrings
{
    //i controlleren skal alt
    class Controller
    {

        private ProfileRepository profileRepository = new ProfileRepository();
        private ProjectRepository projectRepository = new ProjectRepository();
        private EquipmentRepository equipmentRepository = new EquipmentRepository();

        public void CreateNewProfile(int id, string profileName, string profileTelephone = null, string profileEmail = null, string profileSchoolOrCompany = null)
        {
            profileRepository.CreateNewProfile(id, profileName, profileTelephone, profileEmail, profileSchoolOrCompany);
        }
        public void CreateNewProject(int id, string projectName, string projectDescription)
        {
            projectRepository.CreateNewProject(id, projectName, projectDescription);
        }

        public List <Profile> ShowProfiles()
        {
            return profileRepository.GetProfiles();
        }

        public List<Project> ShowProjects()
        {
            return projectRepository.GetProjects();
        }

        public List<Equipment> ShowEquipmentToBook()
        {
            return equipmentRepository.GetEquipment();
        }
    }
}

