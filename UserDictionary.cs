using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class UserDictionary
    {
        static void Main(string[] args)
        {
            try
            {
                string gname, glevel,ask,repeat;
                int gid, grank;
                Dictionary<int, GMUser> gmusers = new Dictionary<int, GMUser>();
                GMUser u1 = new GMUser()
                {
                    GID=101,
                    Gname ="Rosky",
                    GCategory = "Diammond",
                    GRank = 24
                };
                gmusers.Add(u1.GID,u1);
                do
                {
                    Console.WriteLine("1. Add New Player");
                    Console.WriteLine("2. Search Player");
                    Console.WriteLine("3. Display Player");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("--------------- Select Choice ---------------");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            again:
                                GMUser user = new GMUser();
                            Console.WriteLine("Enter Gaming ID: ");
                            gid = Convert.ToInt32(Console.ReadLine());
                            if (!gmusers.ContainsKey(gid))
                            {
                                user.GID = gid;
                            }
                            else
                            {
                                Console.WriteLine("ID: {0} Already Exist\n",gid);
                                int idcount = gid;
                                Console.WriteLine("Available ID: ");
                                for (int i = gid; i < gid+3; i++)
                                {
                                    idcount++;
                                    Console.Write("{0}, ",idcount);
                                }
                                Console.WriteLine();
                                goto again;
                            }
                            Console.WriteLine("Enter Player Name: ");
                            gname = Console.ReadLine();
                            Console.WriteLine("Enter Player Category(Gold/Silver/Diamond): ");
                            glevel = Console.ReadLine();
                            Console.WriteLine("Enter Player Rank: ");
                            grank = Convert.ToInt32(Console.ReadLine());

                            user.Gname = gname;
                            user.GCategory = glevel;
                            user.GRank = grank;

                            gmusers.Add(user.GID, user);
                            Console.WriteLine("******** Player Added Sucessfully!!! ********");
                            Console.WriteLine("Add New Player Again(y/n):");
                            ask = Console.ReadLine().ToLower();

                            if (ask == "y")
                            {
                                goto again;
                            }

                            break;
                        case 2:
                            //This will show only searched entries
                            Console.WriteLine("Enter Player ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            GMUser gUser;  //Reference object to access searched value
                            if(gmusers.TryGetValue(id,out gUser))
                            {
                                Console.WriteLine("Player ID: {0}\nPlayer Name: {1}\nPlayer Category: {2}\nPlayer Rank: {3}",gUser.GID,gUser.Gname,gUser.GCategory,gUser.GRank);
                            }
                            else
                            {
                                Console.WriteLine("Player Not Found");
                            }

                            break;
                        case 3:
                            //This will display all the entries
                            Console.WriteLine("*********** {0} Entries Found *********** ", gmusers.Count());
                            foreach (KeyValuePair<int,GMUser> pair in gmusers)
                            {
                                Console.WriteLine("ID: {0}",pair.Key);
                                GMUser mUser = pair.Value;
                                Console.WriteLine("Player Name: {0}\nPlayer Level: {1}\nPlayer Rank: {2}\n",mUser.Gname,mUser.GCategory, mUser.GRank);
                            }
                            break;
                        case 0:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                    Console.WriteLine("Go Back to Main Menu(y/n): ");
                    repeat = Console.ReadLine().ToLower(); //This will return to Main Menu
                } while (repeat == "y");

                if (repeat.ToLower() == "n")
                {
                    System.Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message);
            }

            Console.ReadKey();
        }
    }

    class GMUser    
    {
        public int GID { get; set; }
        public string Gname { get; set; }
        public string GCategory  { get; set; }
        public int GRank  { get; set; }
    }
}
