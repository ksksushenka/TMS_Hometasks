using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class IsoscelesTriangle : Figure
    {
        public IsoscelesTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("IsoscelesTriangle");
            if (firstSide == secondSide)
            {
                return GetSquareForIsoscelesTriangle(firstSide, secondSide);
            }
            else
            {
                if (firstSide == thirdSide)
                {
                    return GetSquareForIsoscelesTriangle(firstSide, secondSide);
                }
                else
                {
                    return GetSquareForIsoscelesTriangle(secondSide, firstSide);
                }
            }
        }

        private double GetSquareForIsoscelesTriangle(double firstSide, double secondSide)
        {
            return secondSide * Math.Sqrt(4 * Math.Pow(firstSide, 2) - Math.Pow(secondSide, 2)) / 4;
        }
    }
}
