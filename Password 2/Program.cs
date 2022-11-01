using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Logic_Classes;
using System.Threading.Tasks;
using Dancer;

namespace Password_2
{
    public class Program
    {
        public static void Main()
        {
            //var PassCheck = new Logic();
            //PassCheck.Main();
            LoginOrChangePassword();
            Console.ReadKey();
        }
        /*This method will explain the rules for the user, if the password is
         * if the password was incorrect the program will run again*/
        private static void ExplainPasswordRules()
        {
            const string modbank = "Password";

            Console.WriteLine("Hello welcome to " + modbank + ". Enter your password");
            Console.WriteLine("Tryk [Enter] for at logge ind");

            while (Console.ReadKey().Key != ConsoleKey.Enter)

            {
            }

            Console.WriteLine("You password must contain");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"* at least {Logic._checker.MinimumPasswordLength} characthers");
            Task.Delay(500).Wait();
            Console.WriteLine("* a special letter as: !,%,#");
            Task.Delay(500).Wait();
            Console.WriteLine("* at least a number");
            Task.Delay(500).Wait();
            Console.WriteLine("* must not have space");
            Task.Delay(500).Wait();
            Console.WriteLine("* It must not start or end with a number");
            Task.Delay(500).Wait();
            Console.WriteLine("* It at least needs to contain (1) Uppercase letter");
            Task.Delay(500).Wait();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your username");
        }

        public static void LoginOrChangePassword()
        {
            Console.WriteLine("do you wish to login or change password?");
            Console.WriteLine("Press (1) for login. Press (2) for creating a password. Press (3) to change password");


            int number = Convert.ToInt32(Console.ReadLine());

            // I call these methods from my class library, and the class PassCheck
            var pass = Logic.GetStoredPassword();
            var user = Logic.GetStoredUsername();
            bool result = false;
            string oldPassword = "OldPassword";
            //CreatePasswordAndLogin(username);

            switch (number)
            {
                case 1:
                    {
                        Console.Clear();
                        result = Logic.UsernameCompare(user, pass);
                        break;
                    }
                case 2:
                    {
                        ExplainPasswordRules();
                        Logic.CreatePasswordAndLogin(Console.ReadLine());
                        //Logic.UsernameCompare(user, pass);
                        break;
                    }
                case 3:
                    {
                        string password = Logic.ChangePassword(oldPassword);
                        Logic.ChangePassword(password);
                        break;
                    }
            }
            if (result == true)
            {

                Console.WriteLine("Write (1) for football case. Write (2) for dance case.");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:

                        var football = new Football();
                        football.Calculate();
                        //Football.Class1();

                        Console.Clear();
                        break;
                    case 2:
                        //var dancer  = new Dance();
                        //dancer.Something();
                        Dance.Dancing();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}