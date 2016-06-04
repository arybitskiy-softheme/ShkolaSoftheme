using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_2
{
    public class Human
    {
        public string BirthDate { get; set; }
        public string FirstName { get; set; }
        public string Lastame { get; set; }
        public string Age { get; }

        public Human(string FirstName, string Lastame)
        {
            this.FirstName = FirstName;
            this.Lastame = Lastame;
        }

        public Human(string FirstName, string Lastame, string BirthDate)
        {
            this.FirstName = FirstName;
            this.Lastame = Lastame;
            this.BirthDate = BirthDate;
        }

        public bool Equals(Human value)
        {
            return (this.Age == value.Age) && (this.BirthDate == value.BirthDate) && (this.FirstName == value.FirstName) && (this.Lastame == value.Lastame);

        }
        class Program
        {
            static void Main(string[] args)
            {
                Human person1 = new Human("S", "R");
                Human person2 = new Human("S", "R");
                Human person3 = new Human("S", "R", "L");

                Console.WriteLine("person1 = person2 - {0}", person1.Equals(person2));
                Console.WriteLine("person1 = person3 - {0}", person1.Equals(person3));
                Console.ReadKey();

            }
        }
    }
}
