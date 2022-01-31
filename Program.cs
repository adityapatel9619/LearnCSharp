#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //#if (TEST)
            //    Console.WriteLine("TEST is Defined");
            //#else
            //    Console.WriteLine("TEST is Un-Defined");
            //#endif

            Customer c1 = new Customer()
            {
                ID=101,
                Name = "Aditya",
                Age = 21
            };

            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Jhon",
                Age = 32
            };

            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Jimmy",
                Age = 28
            };


            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            customers.Sort();

            foreach (Customer item in customers)
            {
                Console.WriteLine("ID: {0}\nName: {1}\nAge: {2}\n",item.ID,item.Name,item.Age);
            }
            Console.ReadKey();
        }
    }

    public class Customer:IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Customer customer)
        {
            if (this.Age > customer.Age)
            {
                return 1;
            }
            else if (this.Age < customer.Age)
                return -1;
            else
                return 0;
        }
    }
}
