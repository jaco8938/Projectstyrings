using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class BookingRepository
    {
        private List<Booking> bookingList = new List<Booking>();

        public void CreateNewBooking(DateTime dateTime, int equipmentId, string equipment)
        {
            Booking booking = new Booking(dateTime, equipmentId, equipment);
            bookingList.Add(booking);
        }
    }
}
