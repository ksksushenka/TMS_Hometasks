using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson8
{
    internal class Login
    {
        public static bool LogIn(string login, string password, string confirmPassword)
        {
            try
            {
                if (login.Length >= 20 || login.Contains(" "))
                {
                    throw new WrongLoginException("Login Error");
                }

                if (password.Length >= 20 || password.Contains(" ") || !password.Any(char.IsNumber))
                {
                    throw new WrongPasswordException("Password Error");
                }

                if (confirmPassword != password)
                {
                    throw new WrongPasswordException("Password Error");
                }

                Console.WriteLine("Passed");
                return true;
            }
            catch             
            {
                Console.WriteLine("Error");
                return false;
            }
        }
    }
}
