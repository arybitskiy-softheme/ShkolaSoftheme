using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Print
{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine("Method from Base class");
            Console.WriteLine(value);
        }
    }

    public class ColourPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.WriteLine("Method from ColourPrinter class");
            base.Print(value);
        }
        public void Print(string text, string color)
        {
            Console.WriteLine("Method from ColourPrinter class");
            Console.WriteLine("Text - {0}, Color - {1}", text, color);
        }
    }

    public class PhotoPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.WriteLine("Method from PhotoPrinter class");
            base.Print(value);
        }
        public void Print(Image image)
        {
            Console.WriteLine("Method from PhotoPrinter class");
            Console.WriteLine("Image - {0}", image);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Image image = Image.FromFile(@"D:\ShkolaSoftheme\CSharpHW\11\1\Print\Print\print.png");
            Printer print1 = new Printer();
            ColourPrinter print2 = new ColourPrinter();
            PhotoPrinter print3 = new PhotoPrinter();

            print1.Print("Print");
            print2.Print("Print");
            print2.Print("Print","Color");
            print3.Print("Print");
            print3.Print(image);

            Console.ReadKey();
        }
    }
}
