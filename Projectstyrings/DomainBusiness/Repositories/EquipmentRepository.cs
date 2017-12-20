using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    class EquipmentRepository
    {
        private List<Equipment> availableEquipmentList = new List<Equipment>();

        public List<Equipment> GetEquipment()
        {
            return availableEquipmentList;
        }
    }
}
