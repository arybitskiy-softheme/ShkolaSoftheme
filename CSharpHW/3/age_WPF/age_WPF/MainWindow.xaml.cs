using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace age_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            string input = textBox.Text;
            validateDate(input);
            

        }

        public void validateDate(string a)
        {
            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("uk-UA", true);
                DateTime birthday = DateTime.Parse(a, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                parseDate(a);
            }
            catch (FormatException)
            {
                textBox.Text = "Incorect date format. Should be DD/MM/YYYY";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Error.jpg"));
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;

            }
            
            
        }
        public void parseDate(string date)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("uk-UA", true);
            DateTime birthday = DateTime.Parse(date, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            showAge(birthday);
            Zodiac(birthday);
        }

        public void showAge(DateTime date)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - date.Year;
            textBox1.Text  = "Your age is " + age;
        }

        public void Zodiac(DateTime date)
        {
            int now = date.Year;
            int next = now - 1;
            
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

            string CapricornStart = "22/12/" + next;
            string CapricornEnd = "20/01/" + now;

            string AquariusStart = "21/01/" + now;
            string AquariusEnd = "19/02/" + now;

            string PiscesStart = "20/02/" + now;
            string PiscesEnd = "20/03/" + now;


            if (DateTime.Parse(AriesStart) <= date && date < DateTime.Parse(AriesEnd))
            {
                textBox2.Text = "Your zodiac is Aries";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Aries.png"));
            }
            else if (DateTime.Parse(TaurusStart) <= date && date < DateTime.Parse(TaurusEnd))
            {
                textBox2.Text = "Your zodiac is Taurus";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Taurus.png"));
            }
            else if (DateTime.Parse(GeminiStart) <= date && date < DateTime.Parse(GeminiEnd))
            {
                textBox2.Text =  "Your zodiac is Gemini";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Gemini.png"));
            }
            else if (DateTime.Parse(CancerStart) <= date && date < DateTime.Parse(CancerEnd))
            {
                textBox2.Text = "Your zodiac is Cancer";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Cancer.png"));
            }
            else if (DateTime.Parse(LeoStart) <= date && date < DateTime.Parse(LeoEnd))
            {
                textBox2.Text = "Your zodiac is Leo";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Leo.png"));
            }
            else if (DateTime.Parse(VirgoStart) <= date && date < DateTime.Parse(VirgoEnd))
            {
                textBox2.Text = "Your zodiac is Virgo";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Virgo.png"));
            }
            else if (DateTime.Parse(LibraStart) <= date && date < DateTime.Parse(LibraEnd))
            {
                textBox2.Text = "Your zodiac is Libra";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Libra.png"));
            }
            else if (DateTime.Parse(ScorpioStart) <= date && date < DateTime.Parse(ScorpioEnd))
            {
                textBox2.Text = "Your zodiac is Scorpio";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Scorpio.png"));
            }
            else if (DateTime.Parse(CapricornStart) <= date && date < DateTime.Parse(CapricornEnd))
            {
                textBox2.Text = "Your zodiac is Capricorn";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Capricorn.png"));
            }
            else if (DateTime.Parse(AquariusStart) <= date && date < DateTime.Parse(AquariusEnd))
            {
                textBox2.Text = "Your zodiac is Aquarius";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Aquarius.png"));
            }
            else if (DateTime.Parse(SagittariusStart) <= date && date < DateTime.Parse(SagittariusEnd))
            {
                textBox2.Text = "Your zodiac is Sagittarius";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Sagittarius.png"));
            }
            else if (DateTime.Parse(PiscesStart) <= date && date < DateTime.Parse(PiscesEnd))
            {
                textBox2.Text = "Your zodiac is Pisces";
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Pisces.png"));
            }
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
    }
}
