using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    public class ReverseComparer : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte length = 20;
            byte[] array = new byte[length];
            Random number = new Random();
            number.NextBytes(array);
            DisplayArray(array);


            byte[] sortedArray = array;
            Array.Sort(sortedArray);
            DisplayArray(sortedArray);



            byte[] sortedArrayRev = array;
            IComparer revComparer = new ReverseComparer();
            Array.Sort(sortedArrayRev, revComparer);
            DisplayArray(sortedArrayRev);


            Console.ReadKey();
        }

            public static void DisplayArray(byte[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Array");
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
    }

