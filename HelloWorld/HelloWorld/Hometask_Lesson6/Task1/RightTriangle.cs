﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson6.Task1
{
    internal class RightTriangle : Figure
    {
        public RightTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("RightTriangle");
            if (firstSide > secondSide)
            {
                if (firstSide > thirdSide)
                {
                    return GetSquareForRightTriangle(secondSide, thirdSide);
                }
                else
                {
                    return GetSquareForRightTriangle(firstSide, secondSide);
                }
            }
            else
            {
                if (secondSide > thirdSide)
                {
                    return GetSquareForRightTriangle(firstSide, thirdSide);
                }
                else
                {
                    return GetSquareForRightTriangle(firstSide, secondSide);
                }
            }
        }

        private double GetSquareForRightTriangle(double firstSide, double secondSide)
        {
            return 0.5 * firstSide * secondSide;
        }
    }
}
