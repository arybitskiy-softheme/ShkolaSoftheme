using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace registration
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

        public int FirstName(string firstName)
        {
            int status = 0;
            if (firstName == String.Empty)
            {
                textBoxFirstName.Text = "Please type something";
            }
            else if (firstName.Length >= 255)
            {
                textBoxFirstName.Text = "First name length should be less then 255";
            }
            else if (Regex.IsMatch(firstName, @"^[a-zA-Z]+$")) { status = 1; }
            else { textBoxLastName.Text = "First name should contain leters only"; }
            return status;
        }

        public int LastName(string lastName)
        {
            int status = 0;
            if (lastName == String.Empty)
            {
                textBoxLastName.Text = "Please type something";
            }
            else if (lastName.Length >= 255)
            {
                textBoxLastName.Text = "Last name length should be less then 255";
            }
            else if (Regex.IsMatch(lastName, @"^[a-zA-Z]+$")) { status = 1; }
            else { textBoxLastName.Text = "Last name should contain leters only"; }
            return status;
        }

        public int Birthday(string birthday)
        {
            int status = 0;
            bool date = false;
            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("uk-UA", true);
                DateTime birth = DateTime.Parse(birthday, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                date = true;
            }
            catch (FormatException)
            {
                textBoxBirth.Text = "Incorect date format. Should be DD/MM/YYYY";
                            }
            if (date) { status = 1; }

            return status;
        }

        public int Gender(string gender)
        {
            int status = 0;
            if (gender == String.Empty)
            {
                textBoxGender.Text = "Please type something";
            }
            else if (gender == "male" || gender == "female")
            {
                status = 1;
            }
            else  { textBoxGender.Text = "type male of female"; ; }
            return status;
        }

        public int Email(string email)
        {
            int status = 0;
            if (email == String.Empty)
            {
                textBoxEmail.Text = "Please type something";
            }
            else if (email.Length >= 255)
            {
                textBoxEmail.Text = "Email length should be less then 255";
            }
            else if (IsValid(email)) { status = 1; }
            else { textBoxEmail.Text = "Please type email with @"; }
            return status;
        }

        public int Phone(string phone)
        {
            int status = 0;
            if (phone == String.Empty)
            {
                textBoxPhone.Text = "Please type something";
            }
            else if (phone.Length != 12)
            {
                textBoxPhone.Text = "Phone length should be 12";
            }
            else if (Regex.IsMatch(phone, @"^[0-9]+$")) { status = 1; }
            else { textBoxPhone.Text = "Phone should contain numbers only"; }
            return status;
        }

        public int Info(string info)
        {
            int status = 0;
            if (info == String.Empty)
            {
                textBoxPhone.Text = "Please type something";
            }
            else if (info.Length > 2000)
            {
                textBoxPhone.Text = "Should be less then 2000";
            }
            else { status = 1; }
            
            return status;
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string firstName = textBoxFirstName.Text;

            string lastName = textBoxLastName.Text;

            string birthday = textBoxBirth.Text;

            string gender = textBoxGender.Text;

            string email = textBoxEmail.Text;

            string phone = textBoxPhone.Text;

            string info = textBoxInfo.Text;

            if  (FirstName(firstName) == 1 && LastName(lastName) == 1 && Birthday(birthday) == 1 && Gender(gender) == 1 && Email(email) == 1 && Phone(phone) == 1 && Info(info) == 1)
            {
                result windowResult = new result();
                windowResult.Show();
                windowResult.textBlock.Text = "You registered successfully!";
            }
        }
    }
}
