using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class LoadtoText
    {
        static void Main(string[] args)
        {
            //StreamWriter writer = new StreamWriter(@"C:\Users\adity\Desktop\WriteLines.txt");
            //string[] lines ={"First line", "Second line", "Third line"};
            //writer.WriteLine(lines);

            //using(FileStream fs = new FileStream(@"C:\Users\adity\Desktop\WriteLines.txt", FileMode.Open, FileAccess.Write))
            //{
            //    StreamWriter writer = new StreamWriter(fs);
            //    string[] lines ={"First line", "Second line", "Third line"};
            //    writer.WriteLine(lines);
            //}

            //For writing data to text file
            //using(StreamWriter writer = new StreamWriter(@"C:\Users\adity\Desktop\WriteLines.txt", true))
            //{
            //    string[] lines = { "First line", "Second line", "Third line" };
            //
            //    List<string> line = new List<string>();
            //    line.Add("Hello");
            //    line.Add("This");
            //    line.Add("Is");
            //    line.Add("From");
            //    line.Add("List");
            //    foreach (var item in lines)
            //    {
            //    writer.WriteLine(item);
            //    }
            //    foreach (var item in line)
            //    {
            //        writer.WriteLine(item);
            //    }
            //}


            //List<string> vs = new List<string>();
            //    File.ReadAllLines(@"C:\Users\adity\Desktop\WriteLines.txt");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Size of List before storing = "+vs.Count);
            //Console.ResetColor();
            //Console.WriteLine("Reading Data in File........");
            //foreach (var line in File.ReadAllLines(@"C:\Users\adity\Desktop\WriteLines.txt"))
            //{
            //    vs.Add(line);
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Size of List after storing = " + vs.Count);
            //Console.ResetColor();
            //foreach (var item in vs)
            //{
            //    Console.WriteLine(item);
            //}

            string[] filepath = File.ReadAllLines(@"Z:\C#\Console\LearnCSharp\Logs\LogAddEmployees.txt");
            
            List<EmployeeInfos> infos = new List<EmployeeInfos>();
            Console.WriteLine(infos.Count());
            foreach (var i in filepath)
            {
                //Not Working
                //string[] temp = i.Split(' ');
                //if (temp.Length >= 1)
                //{
                //    EmployeeInfos employee = new EmployeeInfos();
                //    employee.EmpID = temp[0].Trim();
                //    employee.Name = temp[1].Trim();
                //    employee.Age = Convert.ToInt32(temp[2].Trim());
                //    employee.Role = temp[3].Trim();
                //    infos.Add(employee);
                //}

                //Working
                string[] str = filepath;
                if(str.Length >=3)
                {
                    EmployeeInfos employee = new EmployeeInfos();
                    employee.EmpID = str[0];
                    employee.Name = str[1];   
                    employee.Age = int.Parse(str[2]);
                    employee.Role = str[3];
                    infos.Add(employee);
                }
            }
            Console.WriteLine(infos.Count());

            if(infos.Count() != 0) { 
            Console.WriteLine("File Loaded in List....");
            foreach (var item in infos)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}", item.EmpID, item.Name, item.Age, item.Role);
            }
            }
            Console.ReadKey();
        }

        //public static async Task ExampleAsync()
        //{
        //    string[] lines ={
        //    "First line", "Second line", "Third line"};
        //    await File.WriteAllLines("WriteLines.txt", lines);
        //}
    }

    class EmployeeInfos
    {
        public string EmpID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
    }
}
