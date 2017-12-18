using ConnectToDB2017_C06;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings.Data_Access_Layer
{
    class Database_Access
    {
        SqlConnection con = new SqlConnection(DBController.connectionstring);
        List<Profile> GetProfiles()
        {
            List<Profile> resultat = new List<Profile>();

            {
                try
                {
                    con.Open();

                    SqlCommand command1 = new SqlCommand("GetProfiles", con);
                    command1.CommandType = CommandType.StoredProcedure;

                    SqlDataReader readerForCommand1 = command1.ExecuteReader();

                    if (readerForCommand1.HasRows)
                    {
                        while (readerForCommand1.Read())
                        {
                            string ProfileId = readerForCommand1["ProfileId"].ToString(); ;
                            string ProfileName = readerForCommand1["ProfileName"].ToString(); ;
                            string ProfilePhone = readerForCommand1["ProfilePhone"].ToString(); ;
                            string ProfileEmail = readerForCommand1["ProfileEmail"].ToString(); ;
                            string ProfileCompanyOrSchool = readerForCommand1["ProfileCompanyOrSchool"].ToString(); ;
                            //User constructorens navn skal ændres til profile. Det skal også rettes her forneden.
                            // Det der er i User skal være konsistens med det der er i constructoren. Både med navn og rækkefølge
                            Profile x = new Profile(ProfileName, ProfilePhone, ProfileEmail, ProfileCompanyOrSchool);
                            resultat.Add(x);
                        }
                    }
                }
                catch (SqlException error)
                {
                    Console.WriteLine("UPS" + error.Message);
                }
            }
            return resultat;
        }
    }
}
        //public List<Project> GetProjects()
        //{
        //    try
        //    {
        //        con.Open();

        //        SqlCommand command2 = new SqlCommand("GetProjects", con);
        //        command2.CommandType = CommandType.StoredProcedure;

        //        SqlDataReader readerForCommand2 = command2.ExecuteReader();

        //        if (readerForCommand2.HasRows)
        //        {
        //            while (readerForCommand2.Read())
        //            {
        //                string ProjectId = readerForCommand2["ProjectId"].ToString(); ;
        //                string ProjectName = readerForCommand2["ProjectName"].ToString(); ;
        //                string ProjectDescription = readerForCommand2["ProjectDescription"].ToString(); ;
        //                Console.WriteLine(ProjectId + " " + ProjectName + " " + ProjectDescription);
        //            }
        //        }
        //    }
        //    catch (SqlException error)
        //    {
        //        Console.WriteLine("UPS" + error.Message);
        //    }

    //        //Mikkel CreateNewBooking
    //        public void Run()
    //        {
    //            using (SqlConnection con = new SqlConnection(connectionString))
    //                try
    //                {
    //                    con.Open();

    //                    SqlCommand cmd1 = new SqlCommand("InsertBooking", con);
    //                    cmd1.CommanType = CommandType.StoreProcedure;
    //                    cmd1.Parameters.Add(new SqlParameter("@ProfileId"));
    //                    cmd1.Parameters.Add(new SqlParameter("@ProfileName"));

    //                    cmd1.ExecuteNonQuery();
    //                }
    //                catch (SqlException e)
    //                {
    //                    Console.WriteLine("Ups " + e.Message);
    //                }
    //        }
    //    }
    //}
        ////"server" er navnet på vores SQL server, og her connecter den til en local default instance af den SQL server
        //Server srv;
        //srv = new Server();

        ////"Database" er navnet på vores database
        //Database db;
        //db = srv.Databases["navnet på vores database"];

        ////her definere jeg den stored proc
        //StoredProcedure sp;
        //sp = new StoreProcedure(db, "CreateNewBooking");

        ////sætter textmode property til false, og sætter andre object properties
        //sp.TextMode = false;
        //sp.AnsiNullsStatus = false;
        //sp.QuotedIdentifierStatus = false;

        ////tilføjer 2 parametre
        //StoreProcedureParamater param;
        //param = new StoredProcedureParameter(sp, "@profileId", DataType.Int);
        //sp.Parameters.Add(param);
        //StoredProcedureParameter param2;
        //param2 = new StoredProcedureParameter(sp, "@profileName", DataType.NVarChar(50));
        //param2.IsOutputParameter = true;
        //sp.Parameters.Add(param2);

        ////sætter TextBody property til at definere vores storedproc
        //string stmt;
        //stmt = " SELECT @profileName = (SELECT ProfileName FROM Profiles.ProfileName WHERE Profiles.ProfileName.ProfileId = @profileID )";
        //sp.TextBody = stmt;

        ////Create the stored proc i instansen ar SQL serveren
        //sp.Create();


        //}
//    }
//}
