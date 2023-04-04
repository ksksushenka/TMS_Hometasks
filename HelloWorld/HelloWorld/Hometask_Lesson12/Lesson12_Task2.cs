using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson12
{
    internal class Lesson12_Task2
    {
        public static void Lesson12_task2()
        {
            List<User> users = new List<User>
        {
            new User("Kseniya", "Igorevna", "Grebenyuk"),
            new User("Ivan", "", "Petrov"),
            new User("Igor", "Igorevich", "Ivanov")
        };

            User.GetName(users);
            User.SortByLastName(users);
        }
    }
}
