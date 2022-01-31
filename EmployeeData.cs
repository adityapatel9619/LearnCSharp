using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
         /*   try
            {
                EmployeeInfo emp = new EmployeeInfo()
                {
                    EmpID = "101",
                    Name = "Aditya Patel",
                    Age = 22,
                    Role = "Developer"
                };
                EmployeeInfo emp2 = new EmployeeInfo()
                {
                    EmpID = "102",
                    Name = "Ram Singh",
                    Age = 46,
                    Role = "Tester"
                };
                EmployeeInfo emp3 = new EmployeeInfo()
                {
                    EmpID = "103",
                    Name = "Sukhbir Khurana",
                    Age = 34,
                    Role = "Business Analyst"
                };
                string id, name, role, ask, repeat;
                int age;
                List<EmployeeInfo> infos = new List<EmployeeInfo>();//This list will add all employees
                List<EmployeeInfo> addedEmps = new List<EmployeeInfo>();//This list will add the newly inserted employees
                infos.Add(emp);
                infos.Add(emp2);
                infos.Add(emp3);
                //doit:
                do
                {
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Search Employee");
                    Console.WriteLine("3. Display Employee");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("--------- Select Choice ---------");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                        doit:
                            EmployeeInfo info = new EmployeeInfo();
                            Console.WriteLine("Enter ID");
                            id = Console.ReadLine();
                            Console.WriteLine("Enter Name");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Role(Developer/Tester/Business Analyst)");
                            role = Console.ReadLine();

                            info.EmpID = id;
                            info.Name = name;
                            info.Age = age;
                            info.Role = role;

                            infos.Add(info);
                            addedEmps.Add(info);
                            Console.WriteLine("******** Employee Added Sucessfully!!! ********");
                            //This section logs -> newly added employees
                            using(StreamWriter writer = new StreamWriter(@"Z:\C#\Console\LearnCSharp\Logs\LogAddEmployees.txt", true))
                            {
                                writer.WriteLine("{0}\n{1}\n{2}\n{3}\n",info.EmpID,info.Name,info.Age,info.Role);
                            }
                            Console.WriteLine("Add New Employee Again(y/n):");
                            ask = Console.ReadLine().ToLower();

                            if (ask == "y")
                            {
                                goto doit;
                            }
                            else
                            {
                                using(StreamWriter writer = new StreamWriter(@"Z:\C#\Console\LearnCSharp\Logs\LogAllAddedEmployees.txt", true)) {
                                    foreach (EmployeeInfo shwAdde in addedEmps)
                                    {
                                        writer.WriteLine("{0}\n{1}\n{2}\n{3}\n",shwAdde.EmpID,shwAdde.Name,shwAdde.Age,shwAdde.Role);
                                    }
                                }
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Enter Employe Name: ");
                                string search = Console.ReadLine();
                                List<EmployeeInfo> srchData = infos.FindAll(inf => inf.Name.ToLower() == search.ToLower());
                                Console.WriteLine("------ {0} entries found ------", srchData.Count());

                                foreach (EmployeeInfo data in srchData)
                                {
                                    using (StreamWriter writer = new StreamWriter(@"Z:\C#\Console\LearnCSharp\Logs\LogSearchEmployees.txt", true))
                                    {
                                        writer.WriteLine("{0}\n{1}\n{2}\n{3}\n",data.EmpID, data.Name, data.Age, data.Role);
                                    }
                                    Console.WriteLine("ID: {0}\nName: {1}\nAge: {2}\nRole: {3}\n", data.EmpID, data.Name, data.Age, data.Role);

                                }

                            }
                            catch (Exception)
                            {
                                throw new Exception("Employee Not Found");
                            }
                            break;
                        case 3:
                            Console.WriteLine("   ID   |     Name    |  Age  |   Role    |");
                            foreach (EmployeeInfo inf in infos)
                            {
                                Console.WriteLine("  {0}   |     {1}    |  {2}  |   {3}    |", inf.EmpID, inf.Name, inf.Age, inf.Role);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter ID: ");
                            string empid = Console.ReadLine();
                            EmployeeInfo ef= infos.Find(inf => inf.EmpID == empid);
                            Console.WriteLine("\n---------- Details of Emp Id: {0} ----------",ef.EmpID);
                            Console.WriteLine("ID: {0}\nName: {1}\nAge: {2}\nRole: {3}\n",ef.EmpID,ef.Name,ef.Age,ef.Role);
                            Console.WriteLine("---------- Update Details of ID : {0} ----------\n", ef.EmpID);
                            Console.Write("Update Name: "); //Update Name
                            string upname = Console.ReadLine();
                            Console.Write("Update Age: ");
                            int upage = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Update Role: ");
                            string uprole = Console.ReadLine();
                            if(ef.EmpID == empid)
                            {
                                ef.Name = upname;
                                ef.Age = upage;
                                ef.Role = uprole;
                            }
                                Console.WriteLine("\n-------- Employee ID: {0} Details Updated --------\n", ef.EmpID);
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

                if (repeat == "n")
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errors: {0}",ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }*/
        }
    }

    class EmployeeInfo  
    {
        public string EmpID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; } 
    }
}
//if (infos.Exists(inf => inf.Name.StartsWith(search)))
//{
//    Console.WriteLine("Employee with {0} exist",search);
//}
//else
//{
//    Console.WriteLine("Employee with {0} not exist", search);
//}
