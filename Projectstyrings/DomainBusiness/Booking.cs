using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Booking
    {
        public DateTime BookingTime { get; set; }
        public string Equipment { get; set; }
        public int EquipmentId { get; set; }

        public Booking(DateTime dateTime, int equipmentId, string equipment)
        {
            BookingTime = dateTime;
            EquipmentId = equipmentId;
            Equipment = equipment;
        }
    }
}