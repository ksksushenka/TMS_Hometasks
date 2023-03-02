using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    class Hometask_Lesson3
    {
        public static void Lesson3_Task0()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = "This number is not included in the array";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    result = "This number is included in the array";
                }
            }

            Console.WriteLine(result);
        }

        public static void Lesson3_Task1()
        {
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == number)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                int[] array2 = new int[array1.Length - 1];

                for (int i = 0, j = 0; i < array1.Length; i++)
                {
                    if (array1[i] != number)
                    {
                        array2[j++] = array1[i];
                    }
                }

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write(array2[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("This number is not included in this array");
            }
        }

        public static void Lesson3_Task2()
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.Next(1,100);
                Console.Write(array[i] + " ");
            }

            int maxValue = array[0];
            int minValue = array[0];
            double result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }

                result+=array[i];
            }

            Console.WriteLine($"\nMax number is {maxValue}.");
            Console.WriteLine($"Min number is {minValue}.");
            Console.WriteLine("Average is " + result/size);
        }

        public static void Lesson3_Task3()
        {   
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            Random random = new Random();

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = (int)random.Next(1, 100);
                Console.Write(array1[i] + " ");
                sum1 += array1[i];
            }

            Console.Write("\n");

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = (int)random.Next(1, 100);
                Console.Write(array2[i] + " ");
                sum2 += array2[i];
            }

            double result1 = (double)sum1 / 5;
            double result2 = (double)sum2 / 5;

            if (result1 > result2)
            {
                Console.WriteLine($"\n{result1} > {result2}"); 
            }    
            else if (result1 < result2)
            {
                Console.WriteLine($"\n{result1} < {result2}");
            }
            else
            {
                Console.WriteLine($"\n{result1} = {result2}");
            }
        }
    }
}
