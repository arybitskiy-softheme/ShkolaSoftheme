using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy8_1
{
    class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alex";
            string copyName = name;
            User user1 = new User(copyName, 28);
            User user2 = user1;

            ShowUser(user1);
            ShowUser(user1);

            Console.ReadKey();

        }
        static void ShowUser(User value)
        {
            Console.WriteLine("name - {0}, age - {1}", value.Name, value.Age);
        }
    }
}
