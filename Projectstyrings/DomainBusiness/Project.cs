using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Project(int id, string projectName, string projectDescription)
        {
            Id = id;
            Name = projectName;
            Description = projectDescription;
        }
    }
}
