using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFullInfo
{
    public interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }

        string GetFullInfo(UserDB db);
    }

    public interface IValidator
    {
        bool ValidateUser(IUser value, UserDB db);
    }

    public class SignIn
    {

        public string PromptNameOREmail(UserDB db)
        {
            IUser user1 = new GetUserInfo();
            Console.WriteLine("================");
            Console.Write("Enter name or email: ");
            user1.Name = Console.ReadLine();
            user1.Email = user1.Name;
            Console.Write("Enter password: ");
            user1.Password = Console.ReadLine();
            ValidateUserInfo validateUser = new ValidateUserInfo();
            if (validateUser.ValidateUser(user1, db) == false)
            {
                if (user1.GetFullInfo(db) == "exit") return "exit";
            }
            return "noctinue";
        }
    }

    public class GetUserInfo : IUser
    {
        public string Name { get;  set; }
        public string Password { get;  set; }
        public string Email { get;  set; }



        public string GetFullInfo(UserDB db)
        {
            Console.WriteLine("You are not in the system. Please type full info");
            Console.Write("Type your name: ");
            Name = Console.ReadLine();
            Console.Write("Type your email: ");
            Email = Console.ReadLine();
            Console.Write("Type your password: ");
            Password = Console.ReadLine();
            if (Name == "exit" && Email == "exit" && Password == "exit") { return "exit"; }
            else {db.UserDBFill(Name, Email, Password);
                return "continue";               }
            

            
        }
    }

    public class ValidateUserInfo : IValidator
    {
        
        public bool ValidateUser(IUser value, UserDB db)
        {
            string name = value.Name;
            string email = value.Email;
            string password = value.Password;
            
            for (int i = 0; i < 100; i++)
                {
                if (name == db.nameArray[i] || email == db.emailArray[i])
                {
                    if (password == db.passwordArray[i])
                    {
                        Console.WriteLine("Last visit: " + db.timeArray[i]);
                        return true;
                    }
                }
                
            }
            return false;
            {

            }

        }
    }
    public class UserDB
    {
        public string[] nameArray = new string[100];
        public string[] emailArray = new string[100];
        public string[] passwordArray = new string[100];
        public string[] timeArray = new string[100];

        public UserDB()
        {
        }

        public void UserDBFill(string name, string email, string passwor)
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                if (nameArray[i] == null)
                {
                    nameArray[i] = name;
                    emailArray[i] = email;
                    passwordArray[i] = passwor;
                    timeArray[i] = now.Year+"-"+now.Month+"-"+now.Day+" "+now.Hour+":"+now.Minute;
                    Console.WriteLine("User position in array is {0}", i);
                    break;
                }
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            UserDB db = new UserDB();
            for (int i = 0; i >=0; i++)
            {
                SignIn user = new SignIn();
                if (user.PromptNameOREmail(db) == "exit") break;

            }
            
        }
    }
}
