using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson12
{
    internal class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public static void GetName(List<User> users)
        {
            var withMiddleName = from u in users 
                                  where u.MiddleName != "" 
                                  select u;

            foreach (var user in withMiddleName)
            {
                Console.WriteLine($"{user.FirstName} {user.MiddleName} {user.LastName}");
            }

            var withoutMiddleName = from u in users 
                                    where u.MiddleName == "" 
                                    select u;

            foreach (var user in withoutMiddleName)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }

        public static void SortByLastName(List<User> users)
        {
            var sortByLastName = from u in users
                                 orderby u.LastName descending
                                 select u;

            foreach (var user in sortByLastName)
            {
                Console.WriteLine($"{user.FirstName} {user.MiddleName} {user.LastName}");
            }
        }
    }
}
