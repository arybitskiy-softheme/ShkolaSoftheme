using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_console
{
    class Program
    {
        public static DateTime inputBirthday()
        {
            Console.Write("Type your date of birth: ");
            string input = Console.ReadLine();

            validateDate(input);

            IFormatProvider culture = new System.Globalization.CultureInfo("uk-UA", true);
            DateTime birthday = DateTime.Parse(input, culture, System.Globalization.DateTimeStyles.AssumeLocal);


            return birthday;
        }

        public static void validateDate(string a)
        {
            try
            {
                IFormatProvider culture1 = new System.Globalization.CultureInfo("uk-UA", true);
                DateTime birthday1 = DateTime.Parse(a, culture1, System.Globalization.DateTimeStyles.AssumeLocal);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} incorect date format",a);
                Console.ForegroundColor = ConsoleColor.Gray;
                inputBirthday();
            }
        }

        public static void showAge(DateTime date)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - date.Year;
            Console.WriteLine("Your age is {0}", age);
        }

        public static void Zodiac(DateTime date)
        {
            int now = date.Year;
            int next = now + 1;
            //IFormatProvider culture = new System.Globalization.CultureInfo("uk-UA", true);
            string AriesStart = "21/03/"+now;
            string AriesEnd = "20/04/"+now;

            string TaurusStart = "21/04/" + now;
            string TaurusEnd = "21/05/" + now;

            string GeminiStart = "22/05/" + now;
            string GeminiEnd = "21/06/" + now;

            string CancerStart = "22/06/" + now;
            string CancerEnd = "22/07/" + now;

            string LeoStart = "23/07/" + now;
            string LeoEnd = "22/08/" + now;

            string VirgoStart = "23/08/" + now;
            string VirgoEnd = "23/09/" + now;

            string LibraStart = "24/09/" + now;
            string LibraEnd = "23/10/" + now;

            string ScorpioStart = "24/10/" + now;
            string ScorpioEnd = "22/11/" + now;

            string SagittariusStart = "23/11/" + now;
            string SagittariusEnd = "21/12/" + now;

            string CapricornStart = "22/12/" + now;
            string CapricornEnd = "20/01/" + next;

            string AquariusStart = "21/01/" + now;
            string AquariusEnd = "19/02/" + now;

            string PiscesStart = "20/02/" + now;
            string PiscesEnd = "20/03/" + now;


            if (DateTime.Parse(AriesStart) <= date && date < DateTime.Parse(AriesEnd))
            {
                Console.WriteLine("Your zodiac is Aries");
            }
            else if (DateTime.Parse(TaurusStart) <= date && date < DateTime.Parse(TaurusEnd))
            {
                Console.WriteLine("Your zodiac is Taurus");
            }
            else if (DateTime.Parse(GeminiStart) <= date && date < DateTime.Parse(GeminiEnd))
            {
                Console.WriteLine("Your zodiac is Gemini");
            }
            else if (DateTime.Parse(CancerStart) <= date && date < DateTime.Parse(CancerEnd))
            {
                Console.WriteLine("Your zodiac is Cancer");
            }
            else if (DateTime.Parse(LeoStart) <= date && date < DateTime.Parse(LeoEnd))
            {
                Console.WriteLine("Your zodiac is Leo");
            }
            else if (DateTime.Parse(VirgoStart) <= date && date < DateTime.Parse(VirgoEnd))
            {
                Console.WriteLine("Your zodiac is Virgo");
            }
            else if (DateTime.Parse(LibraStart) <= date && date < DateTime.Parse(LibraEnd))
            {
                Console.WriteLine("Your zodiac is Libra");
            }
            else if (DateTime.Parse(ScorpioStart) <= date && date < DateTime.Parse(ScorpioEnd))
            {
                Console.WriteLine("Your zodiac is Scorpio");
            }
            else if (DateTime.Parse(CapricornStart) <= date && date < DateTime.Parse(CapricornEnd))
            {
                Console.WriteLine("Your zodiac is Capricorn");
            }
            else if (DateTime.Parse(AquariusStart) <= date && date < DateTime.Parse(AquariusEnd))
            {
                Console.WriteLine("Your zodiac is Aquarius");
            }
            else if (DateTime.Parse(SagittariusStart) <= date && date < DateTime.Parse(SagittariusEnd))
            {
                Console.WriteLine("Your zodiac is Sagittarius");
            }
            else if (DateTime.Parse(PiscesStart) <= date && date < DateTime.Parse(PiscesEnd))
            {
                Console.WriteLine("Your zodiac is Pisces");
            }
        }


        static void Main(string[] args)
        {
            DateTime birthday = inputBirthday();
            showAge(birthday);
            Zodiac(birthday);

            Console.ReadKey();
        }
    }
}
