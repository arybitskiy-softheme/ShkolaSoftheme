using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
        begining:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to calculator!");
            Console.Write("Input first number and press enter: ");
            string input = Console.ReadLine();
            try
            {
                double value = double.Parse(input);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} is not a valid number", input);
                Console.ForegroundColor = ConsoleColor.White;
                goto begining;
            }
            double number1 = Convert.ToDouble(input);
            Console.WriteLine("To select operation input any of this symbols: +,-,*,/ :");
            string operation = Console.ReadLine();
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                Console.Write("Input second number and press enter: ");
                string input2 = Console.ReadLine();
                try
                {
                    double value = double.Parse(input2);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} is not a valid number", input2);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto begining;
                }
                double number2 = Convert.ToDouble(input2);
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                }
                Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, Math.Round(result, 2));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect input :(");
                Console.ForegroundColor = ConsoleColor.White;
                goto begining;
            }

            Console.ReadKey();
        }
    }
}
