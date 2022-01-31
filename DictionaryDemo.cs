using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            try
            {
                User u1 = new User()
                {
                    ID = 101,
                    UserId = "aditya123",
                    Name = "Aditya Patel",
                    Age = 23
                };
                User u2 = new User()
                {
                    ID = 102,
                    UserId = "donut123",
                    Name = "Gordon Jose",
                    Age = 27
                };
                User u3 = new User()
                {
                    ID = 103,
                    UserId = "djjohn287",
                    Name = "Jhon D'souza",
                    Age = 31
                };

                Dictionary<int, User> dictUser = new Dictionary<int, User>();
                dictUser.Add(u1.ID, u1);
                dictUser.Add(u2.ID, u2);
                dictUser.Add(u3.ID, u3);

                User v1 = dictUser[103];
                //Console.WriteLine("ID = {0}\nUserId = {1}\nName = {2}\nAge = {3}",v1.ID,v1.UserId,v1.Name,v1.Age);

                foreach (KeyValuePair<int, User> pair in dictUser)
                {
                    Console.WriteLine("ID -> {0}", pair.Key);
                    User user = pair.Value;
                    Console.WriteLine("User ID: {0}\nName: {1}\nAge: {2}", user.UserId, user.Name, user.Age);
                    Console.WriteLine("-------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message);
            }


            Console.ReadKey();
        }
    }

    class User  
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
