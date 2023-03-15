using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson6.Task1
{
    internal class Rectangle : Figure
    {
        public Rectangle(double length, double width) : base(length, width)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Rectangle");
            return length * width;
        }
    }
}
