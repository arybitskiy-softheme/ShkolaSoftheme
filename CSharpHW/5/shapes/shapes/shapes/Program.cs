using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            begining:
            Console.WriteLine("Select shape:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Romb");
            Console.Write("Your choise: ");
            int shape = int.Parse(Console.ReadLine());

            //Console.Write("Enter heights: ");
            // int heights = int.Parse(Console.ReadLine());
            //Console.Write("Enter width: ");
            //int width = int.Parse(Console.ReadLine());

            if (shape == 1)
            {
                Console.Write("Enter heights: ");
                int heights = int.Parse(Console.ReadLine());
                for (int h = 0; h <= heights; h++)
                {
                    for (int w = 0; w <= h; w++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine("");
                }
            }
            else if (shape == 2)
            {
                Console.Write("Enter heights: ");
                int heights = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                int width = int.Parse(Console.ReadLine());
                for (int h = 0; h <= heights; h++)
                {
                    for (int w = 0; w <= width; w++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine("");
                }
            }
            else if (shape == 3)
            {

                Console.Write("Enter heights: ");
                int heights = int.Parse(Console.ReadLine());
                for (int h = heights; h > 0; h--)
                {
                    for (int w = h; w > 1; w--)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 0; j < (heights - h) * 2 + 1; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                for (int h = heights; h > 0; h--)
                {
                    for (int q = 0; q < (heights - h + 1); q++)
                    {
                        Console.Write("  ");
                    }
                    for (int w = h * 2 - 2; w > 1; w--)
                    {
                        Thread.Sleep(100);
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }


            }
            else { goto begining; }
            Console.ReadKey();
        }
    }
}
