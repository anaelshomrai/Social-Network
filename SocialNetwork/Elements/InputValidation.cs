using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
     static class InputValidation
    {

         public static string CheckFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName) == true)
            {
                return "First Name cannot be empty!";
            }
            else if (firstName.Any(c => char.IsDigit(c)) == true)
            {
                return "First Name cannot contain any numbers!";
            }
            else
            return "";

        }
         public static string CheckLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName) == true)
            {
                return "Last Name cannot be empty!";
            }
            else if (lastName.Any(c => char.IsDigit(c)) == true)
            {
                return "Last Name cannot contain any numbers!";
            }
            else
                return "";
        }

         public static string CheckGender(string gender)
        {
            if (string.IsNullOrEmpty(gender) == true)
            {
                gender = "N/A";
            }
            else if (string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase) == false && 
                string.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase)== false && 
                string.Equals(gender, "N/A", StringComparison.OrdinalIgnoreCase) == false)
            {
                  return "Invalid Gender (Male/Female or N/A)";
            }
            return "";

        }

         public static string CheckUserName(string userName)
        {
            DB dataBase = DB.GetInstance();

            foreach (AbstractUser u in dataBase.Users)
            {
                if (u.UserName == userName)
                {
                    return ("User name is taken!, chose another one");
                }
            }

            if (userName.Length > 15 || userName.Length < 2)
            {
                return("Invalid user name (up to 15 letters, minimum 4))");
            }
            else if (string.IsNullOrEmpty(userName))
            {
                return ("You must enter a user name!");
            }
            return "";
        }

         public static string CheckPassword(string password)
        {
            if (password.Length < 6 || password.Length > 15)
            {
               return("Invalid password (up to 15 letters, minimum 6))");
            }
            return "";
        }
    }
}
