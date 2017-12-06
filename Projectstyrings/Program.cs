using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//DBControler
namespace ConnectToDB2017_C06
{
    class Program
    {
        public static string connectionstring =
           "Server=EALSQL1.eal.local; Database= DB2017_C06; User Id=USER_C06; Password=SesamLukOp_06;";
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }

        //Controller
        private void Run()
        {
            private list<User> GetProfiles()
            {
                List<User> resultat = new List<User>();
                using (SqlConnection con = new SqlConnection(connectionstring))
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
                                User x = new User(ProfileName, ProfilePhone, ProfileEmail, ProfileCompanyOrSchool);
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
            //void skal fjernes
            private void GetProjects()
            {
                SqlCommand command2 = new SqlCommand("GetProjects", con);
                command2.CommandType = CommandType.StoredProcedure;

                SqlDataReader readerForCommand2 = command2.ExecuteReader();

                if (readerForCommand2.HasRows)
                {
                    while (readerForCommand2.Read())
                    {
                        string ProjectId = readerForCommand2["ProjectId"].ToString(); ;
                        string ProjectName = readerForCommand2["ProjectName"].ToString(); ;
                        string ProjectDescription = readerForCommand2["ProjectDescription"].ToString(); ;
                        Console.WriteLine(ProjectId + " " + ProjectName + " " + ProjectDescription);
                    }
                }
                catch (SqlException error)
                {
                    Console.WriteLine("UPS" + error.Message);
                }
                
            }
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
