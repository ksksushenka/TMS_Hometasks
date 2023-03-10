using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class Square : Figure
    {
        public Square(double length, double width) : base(length, width)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Square");
            return Math.Pow(length, 2);
        }
    }
}
