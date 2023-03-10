using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class Figure
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;
        public double length;
        public double width;

        public Figure(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public Figure(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public virtual double GetSquare()
        {
            return 1;
        }
    }
}
