using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car8_2
{
    public class Engine
    {
        public Engine(string value)
            {
            this.EngionType = value;
            }

        public string EngionType { get; set; }

    }

    public class Color
    {
        public Color(string value)
        {
            this.ColorType = value;
        }

        public string ColorType { get; set; }
    }

    public class Transmission
    {
        public Transmission(string value)
        {
            this.TransmissionType = value;
        }

        public string TransmissionType { get; set; }
    }

    class CarConstructor
    {
        public Car Construct(Engine engine, Color color, Transmission transmission)
        {
            Car car = new Car(engine, color, transmission);
            return car;
        }

        public Car Reconstruct(Car car, Engine engion)
        {
            car.EngionType = engion.EngionType;
            return car;
        }
    }

        public class Car
        {
           public Car(Engine engine, Color color, Transmission transmission)
            {
                this.EngionType = engine.EngionType;
                this.ColorType = color.ColorType;
                this.TransmissionType = transmission.TransmissionType;
            }
                public string EngionType { get; set; }
                public string ColorType { get; set; }
                public string TransmissionType { get; set; }

    }     
    

    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine("MPI");
            Engine engine1 = new Engine("TFSI");
            Color color = new Color("Red");
            Transmission transmission = new Transmission("Auto");

            CarConstructor ConstructCar = new CarConstructor();
            CarConstructor ConstructCar1 = new CarConstructor();
            Car car = ConstructCar.Construct(engine,color,transmission);
            Car car1 = ConstructCar1.Construct(engine, color, transmission);
            ConstructCar1.Reconstruct(car1, engine1);

            ShowCar(car);
            ShowCar(car1);

            Console.ReadKey();

        }
        static void ShowCar(Car value)
        {
            Console.WriteLine("Engion - {0}, Color - {1}, Transmission - {2}", value.EngionType, value.ColorType, value.TransmissionType);
        }
    }
}
