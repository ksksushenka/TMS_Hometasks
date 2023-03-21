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
                if (login.Length >= 20 || login.Contains(" "))
                {
                    throw new WrongLoginException("The login does not match the requirements");
                }

                if (password.Length >= 20 || password.Contains(" ") || !password.Any(char.IsNumber))
                {
                    throw new WrongPasswordException("The password does not match the requirements");
                }

                if (confirmPassword != password)
                {
                    throw new WrongPasswordException("The password and confirmPassword are not equal.");
                }

                Console.WriteLine("Passed");
                return true;
        }
    }
}
