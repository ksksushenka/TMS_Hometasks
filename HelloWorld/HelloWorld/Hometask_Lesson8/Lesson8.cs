using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson8
{
    internal class Lesson8
    {
        public static void Lesson8_task1()
        {
            try
            {
                Login.LogIn("sa d", "mdlkwq", "mdlks1wq");      //incorrect login
            }
            catch (WrongLoginException wrongLoginEx)
            {
                Console.WriteLine(wrongLoginEx.Message);
            }
            catch (WrongPasswordException wrongPasswordEx)
            {
                Console.WriteLine(wrongPasswordEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Login.LogIn("sad", "mdnskjdwq", "mdlks1wq");     //incorrect password
            }
            catch (WrongLoginException wrongLoginEx)
            {
                Console.WriteLine(wrongLoginEx.Message);
            }
            catch (WrongPasswordException wrongPasswordEx)
            {
                Console.WriteLine(wrongPasswordEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Login.LogIn("sad", "md1lkwq", "md1kwq");     //incorrect confirmPassword
            }
            catch (WrongLoginException wrongLoginEx)
            {
                Console.WriteLine(wrongLoginEx.Message);
            }
            catch (WrongPasswordException wrongPasswordEx)
            {
                Console.WriteLine(wrongPasswordEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Login.LogIn("sad", "mdlkwq", "mdlkwq");    //correct data
            }
            catch (WrongLoginException wrongLoginEx)
            {
                Console.WriteLine(wrongLoginEx.Message);
            }
            catch (WrongPasswordException wrongPasswordEx)
            {
                Console.WriteLine(wrongPasswordEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
