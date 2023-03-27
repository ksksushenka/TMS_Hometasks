using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson10.Task3
{
    internal class Point<T>
    {
        T X { get; set; }
        T Y { get; set; }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }

        public void GetInfo()
        {
            Console.WriteLine($"X - {X}, y - {Y}.");
        }

        public static void GetDistance(Point<double> a, Point<double> b)
        {
            double distance = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            Console.WriteLine(distance);
        }

    }
}
