using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArray
{
    public class ArrayManager
    {

        public void Add (int[] array, int element, int index)
        {
            array[index] = element;
        }

        public int GetByIndex(int[] array, int index)
        {
            return array[index];
        }

        public bool Contains (int[] array, int value)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
                
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            ArrayManager arrayManager = new ArrayManager();
            arrayManager.Add(array, 6, 0);
            int value = arrayManager.GetByIndex(array, 6);
            bool contains = arrayManager.Contains(array, 34);

            Console.WriteLine("{0} {1} {2}",array[0],value,contains);
            Console.ReadKey();

        }
    }
}
