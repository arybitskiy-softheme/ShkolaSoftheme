using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 1001;
            int[] array = new int[arrayLength];
            
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (i == j) continue;
                    if (array[i] == array[j])
                    {
                        break;
                    }
                    else if (j == arrayLength-1)
                    {
                        Console.WriteLine("{0} is storred once", array[i]);
                        goto end;
                    }
                }
            }
            end:
            Console.ReadKey();
        }
    }
}
