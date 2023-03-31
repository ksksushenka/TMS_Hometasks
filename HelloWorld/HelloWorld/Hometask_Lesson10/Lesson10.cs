using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Hometasks.Hometask_Lesson10.Task2;
using TMS_Hometasks.Hometask_Lesson10.Task3;

namespace TMS_Hometasks.Hometask_Lesson10
{
    internal class Lesson10
    {
        public static void Lesson10_task1()
        {
            MyArray<string>.AddToArray("spring");
            MyArray<string>.AddToArray("summer");
            MyArray<string>.RemoveFromArray("spring");
            MyArray<string>.GetElementFromArray(0);
            MyArray<string>.GetLenghtFromArray();
        }

        public static void Lesson10_task2()
        {
            var cooper = new Car<Electro>(new Electro());

            cooper.Move();
            cooper.Refueling();
        }

        public static void Lesson10_task3()
        {
            var point1 = new Point<double>(5, 6);
            var point2 = new Point<double>(-6, -4);

            point1.GetInfo();
            point2.GetInfo();

            Point<double>.GetDistance(point1, point2);
        }
    }
}

