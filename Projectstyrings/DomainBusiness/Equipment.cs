using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentType { get; set; }
        public DateTime AvailableBooking { get; set; }

        public Equipment(int equipmentId, string equipmentType, DateTime availableBooking)
        {
            EquipmentId = equipmentId;
            EquipmentType = equipmentType;
            AvailableBooking = availableBooking;
        }


    }
}
