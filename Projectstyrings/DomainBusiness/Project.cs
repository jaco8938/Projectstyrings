using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Project(string id, string projectName, string projectDescription)
        {
            Id = id;
            Name = projectName;
            Description = projectDescription;
        }
    }
}
