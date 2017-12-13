using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectstyrings.Data_Access_Layer;
namespace Projectstyrings
{
    public class ProjectRepository
    {
        private List<Project> projects = new List<Project>();
        public ProjectRepository()
        {
            Database_Access DB = new Database_Access();
            projects = DB.GetProjects();
        }

        public List<Project> GetProjects()
        {
            return projects;
        }
        public void CreateNewProject(string projectName, string projectDescription)
        {
            Project newProject = new Project();

            newProject.Name = projectName;
            newProject.Description = projectDescription;

            projects.Add(newProject);
        }
    }
}
