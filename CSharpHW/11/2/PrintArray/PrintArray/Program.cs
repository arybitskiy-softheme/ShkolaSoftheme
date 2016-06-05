using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Print;
using System.Drawing;

namespace PrintArray
{
    public class ColourPrinterArray : ColourPrinter
    {
        public void PrintArray(string[] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                base.Print(array[i]);
            }
        }
    }

    public class PhotoPrinterArray : PhotoPrinter
    {
            public void PrintArray(Image[] array)
            {
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    base.Print(array[i]);
                }
            }

        }

    class Program
    {
        static void Main(string[] args)
        {
                string[] stringArray = { "One", "Two", "Three", "Four", "Five", "Six", "Seven" };
                Image image1 = Image.FromFile(@"D:\ShkolaSoftheme\CSharpHW\11\1\Print\Print\print.png");
                Image image2 = Image.FromFile(@"D:\ShkolaSoftheme\CSharpHW\11\2\PrintArray\PrintArray\print1.png");
                Image image3 = Image.FromFile(@"D:\ShkolaSoftheme\CSharpHW\11\2\PrintArray\PrintArray\print1.png");
                Image[] imageArray = {image1, image2, image3 };
                ColourPrinterArray print1 = new ColourPrinterArray();
                PhotoPrinterArray print2 = new PhotoPrinterArray();
                print1.PrintArray(stringArray);
                print2.PrintArray(imageArray);


                Console.ReadKey();
        }
    }
}
