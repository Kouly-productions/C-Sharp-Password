using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Logic_Classes
{
    public static class Constants
    {
        public const string PasswordPath = @"F:\Pass.txt";
        public const string UsernamePath = @"F:\Pass.txt";
    }

    public class Logic
    {
        public static readonly ValidatePassword _checker = new ValidatePassword();

        public void Main()
        {
            Console.Clear();
            Environment.Exit(0);
        }

        public static string GetStoredUsername()
        {
            //This string user, will save the username from the text file Username, and then save it
            string user = System.IO.File.ReadAllText(Constants.UsernamePath);
            return user;
        }

        public static string GetStoredPassword()
        {
            string PasswordPath = Constants.PasswordPath;
            //This tring pass, will read the folder it which is named Password. And then save it.
            string pass = System.IO.File.ReadAllText(PasswordPath);
            return pass;
        }

        public static bool UsernameCompare(string user, string pass)
        {
            //Log will contain the username now will type
            string Log;
            Console.WriteLine("Please Enter your Username");
            Log = Console.ReadLine();
            //Now it will check if the username (user) just types is the exact same as the one in the text file
            if (Log == user)
            {
                //I call this method, if the Username was correct
                PasswordCompare(pass);

                return true;
            }
            //Else it the user name is incorrect
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your username was incorrect");
                return false;
            }
        }

        public static string ChangePassword(string password)
        {

            while (true)
            {
                Console.WriteLine("Enter your password");

                password = Console.ReadLine();

                /*If it was a valid check, it will save it inside a text document, and say thanks.
                Then the loop will break*/
                if (_checker.IsValid(password))
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;

                    File.WriteAllText(Constants.PasswordPath, password);

                    Console.WriteLine("Du har ændret dit password.");
                    Console.ReadKey();
                    break;
                }
                /*If the code was not valid, it will say that it wasn't a valid password. 
                And then go back to the loop until the password is valid*/
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"* Password was incorrect, your password must contain {_checker.MinimumPasswordLength} characthers ");
                Console.WriteLine(
                    $"* contains a (special characther) and a (number).");
                Console.WriteLine(
                    $"* It must not conain space");
                Console.WriteLine(
                    $"* Must not start or end with a number");
                Console.WriteLine(
                    $"* Must have an uppercase letter");
                Console.ReadKey();
            }
            return password;
        }

        //When this method is being called, it will compare the two passwords, and make sure they are the same
        public static void PasswordCompare(string pass)
        {
            //Log is just here to read the users name, and being able to compare them
            string Log;
            Console.WriteLine("Please Enter your Password");
            Log = Console.ReadLine();

            //Now it will check if the Password (user) just types is the exact same as the one in the text file
            if (Log == pass)
            {
                Console.WriteLine("Login was succesful");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your password was incorrect");
            }
        }
        //This method holds the (Password) creation and login
        public static void CreatePasswordAndLogin(string username)
        {
            File.WriteAllText(Constants.UsernamePath, username);

            string password;

            //This will loop, until the user types a password that meets all the requirements
            while (true)
            {
                Console.WriteLine("Enter your password");

                password = Console.ReadLine();

                /*If it was a valid check, it will save it inside a text document, and say thanks.
                Then the loop will break*/
                if (_checker.IsValid(password))
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;

                    File.WriteAllText(Constants.PasswordPath, password);

                    Console.WriteLine("Thank you for creating your password.");
                    Console.ReadKey();

                    break;
                }
                /*If the code was not valid, it will say that it wasn't a valid password. 
                And then go back to the loop until the password is valid*/
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"* Password is not valid. Make sure it is over {_checker.MinimumPasswordLength} characters long ");
                Console.WriteLine(
                    $"* contains a (special symbol) and a (number).");
                Console.WriteLine(
                    $"* it dosen't have any spaces");
                Console.WriteLine(
                    $"* it dosen't start and/or end with a number");
                Console.WriteLine(
                    $"* It has an uppercase letter");
                Console.ReadKey();
            }

            Console.WriteLine($"Thank you for logging in {username}.");
            //File.WriteAllText(Directory.GetCurrentDirectory(), $"Username: {username}, Password: {password}");
        }
    }
}
