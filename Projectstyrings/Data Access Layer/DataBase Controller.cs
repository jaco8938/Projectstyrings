using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectstyrings.Data_Access_Layer;

namespace ConnectToDB2017_C06
{
    class DBController
    {
        public static string connectionstring =
          "Server=EALSQL1.eal.local; Database= DB2017_C06; User Id=USER_C06; Password=SesamLukOp_06;";
        private Database_Access DbAccess = new Database_Access();

        public void GetProfiles()
        {
            DbAccess.GetProfiles();
        }
        public void GetProjects()
        {
            DbAccess.GetProjects();
        }
    }
}
