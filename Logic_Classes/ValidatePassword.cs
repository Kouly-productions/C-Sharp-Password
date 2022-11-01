using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Logic_Classes
{
    public class ValidatePassword //some code from class Cheker witch validate password requriments 
    {

        public ValidatePassword()
        {

        }

        public bool IsValid(string password)
        {
            return ContainsSpecialCharacter(password) &&
                    IsAboveMinimumLength(password) &&
                    ContainsNumbers(password) &&
                    NoWhiteSpace(password) &&
                    NoStartOrEndNum(password) &&
                    anyUpperCase(password);
        }

        //This gives MinimunPasswordLength a value of 12
        public int MinimumPasswordLength => 12;

        //This will culcolate MinimunPassworLenght, and check if the password has more than 12 characthers or not
        public bool IsAboveMinimumLength(string password) => password.Length > MinimumPasswordLength;

        /*This method holds the symbolds which is numbers that will be checked for. So if the code dosen't
        hold these numbers the password will be wrong*/
        private bool ContainsNumbers(string password)
        {
            Regex num = new Regex("[1234567890]");
            return num.IsMatch(password);
        }

        //Same thing here, the code most have these symbols or else it's wrong
        public bool ContainsSpecialCharacter(string password)
        {
            Regex rgx = new Regex("[-!#I w¤*&/()=?]");
            return rgx.IsMatch(password);
        }

        //If password has space, it's wrong
        public bool NoWhiteSpace(string Password)
        {
            return !Password.Any(x => x == ' ');
        }

        //This does so the password can't contain numbers at the beginning and the end
        public bool NoStartOrEndNum(string password)
        {
            Regex StartEnd = new Regex("^\\D(.+)*?\\D$");
            return StartEnd.IsMatch(password);
        }
        //This will check if the password contains uppercase letters
        public bool anyUpperCase(string password)
        {
            Regex Upper = new Regex("[A-Z]+");
            return Upper.IsMatch(password);
        }

        public string IsPasswordLengthValid(string Password)
        {
            if (Password.Length > 12)
                return "";
            else
                return "Password length not valid";
        }

        public PassWordResponse IsPasswordLengthValidWithReturnObj(string Password)
        {
            var temp = new PassWordResponse() { Valid = true };

            if (Password.Length > 12)
            {
                temp.Valid = true;
                return temp;
            }

            temp.Valid = false;
            temp.ErrorMessege = "Password length not valid";
            return temp;
        }
        public class PassWordResponse
        {
            public bool Valid { get; set; }
            public string ErrorMessege { get; set; }
        }
    }
}