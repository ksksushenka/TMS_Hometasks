using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Hometasks.Hometask_Lesson10.Task2;

namespace TMS_Hometasks.Hometask_Lesson10
{
    internal class Lesson10_Task2
    {
        public static void Lesson10_task2()
        {
            var cooper = new Car<Electro>(new Electro());

            cooper.Move();
            cooper.Refueling();
        }
    }
}
