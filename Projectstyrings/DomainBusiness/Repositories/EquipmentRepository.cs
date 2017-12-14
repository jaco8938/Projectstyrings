using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    class EquipmentRepository
    {
        private List<Equipment> equipmentList = new List<Equipment>();

        public List<Equipment> GetEquipment()
        {
            return equipmentList;
        }
    }
}
