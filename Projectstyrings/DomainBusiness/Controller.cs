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
        private ProjectRepository projectRepository = new ProjectRepository();
        public List<Project> ShowProjects()
        {
            return projectRepository.GetProjects();
        }

        private BookingRepository bookingRepository = new BookingRepository();
        public List<Booking> ShowBookings()
        {
            return bookingRepository.GetBookings();
        }

            

            //void skal fjernes
            
            //static void Main(string[] args)
            //{
            //    Program myProgram = new Program();
            //    myProgram.Run();
            //}

            //private void Run()
            //{
            //    Menu menu = new Menu();
            //    menu.RunMenu();
            //}
        }
    }

