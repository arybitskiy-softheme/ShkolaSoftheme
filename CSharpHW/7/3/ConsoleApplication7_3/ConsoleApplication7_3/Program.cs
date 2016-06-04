using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_3
{
    class Point
    {
        private int A;
        private int B;

        public Point (int a, int b)
        {
            this.A = a;
            this.B = b;
        }

    }

    class ShapeDescriptor
    {
        private int A;
        private int B;
        private int C;
        private int D;

        public string Shape { get; private set; }

        public ShapeDescriptor()
        {
            this.Shape = "";
        }

        public ShapeDescriptor(Point a, Point b)
        {
            this.Shape = "line";
        }

        public ShapeDescriptor(Point a, Point b, Point c)
        {
            this.Shape = "triangle";
        }

        public ShapeDescriptor(Point a, Point b, Point c, Point d)
        {
            this.Shape = "squer";
        }

        public string ReturnShape()
        {
            return this.Shape;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3);
            Point point2 = new Point(2, 3);
            Point point3 = new Point(2, 3);
            Point point4 = new Point(2, 3);

            ShapeDescriptor Shape1 = new ShapeDescriptor(point1,point2);
            Console.WriteLine(Shape1.ReturnShape());

            ShapeDescriptor Shape2 = new ShapeDescriptor(point1, point2, point3);
            Console.WriteLine(Shape2.ReturnShape());
            Console.ReadKey();
        }
    }
}
