using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_1
{
    public class Car
    {

        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
    }

    public static class TuningAtelier
    {
        public static void TuneCar (Car car)
        {
            car.Color = "red";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            TuningAtelier.TuneCar(car);
            Console.WriteLine(car.Color);
            Console.ReadKey();

        }
    }
}
