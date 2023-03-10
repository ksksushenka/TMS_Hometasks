using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class FigureBuilder
    {
        public FigureBuilder() { }

        public Figure CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
            }
            else if ((Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) == Math.Pow(thirdSide, 2)) || (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2)) || (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2)))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            else if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            else
            {
                return new VersatileTriangle(firstSide, secondSide, thirdSide);
            }
        }

        public Figure CreateRectangle(double lenght, double width)
        {
            if (lenght == width)
            {
                return new Square(lenght, width);
            }
            else
            {
                return new Rectangle(lenght, width);
            }
        }
    }
}
