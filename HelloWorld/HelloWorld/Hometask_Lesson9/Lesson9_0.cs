using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson9
{
    internal class Lesson9_0
    {
        public static void Lesson9_0_1()
        {
            ArrayList list = new ArrayList();

            try
            {
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"An ArgumentOutOfRangeException occurred: {ex.Message}.");
            }
        }

        public static void Lesson9_0_2()
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" }
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
