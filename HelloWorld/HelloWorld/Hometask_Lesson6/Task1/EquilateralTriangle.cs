using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class EquilateralTriangle : Figure
    {
        public EquilateralTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }

        public override double GetSquare()
        {
            Console.WriteLine("EquilateralTriangle");
            return Math.Sqrt(3) * Math.Pow(firstSide, 2) / 4;
        }
    }
}
