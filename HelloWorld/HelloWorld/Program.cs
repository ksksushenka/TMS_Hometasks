using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson2_Task4_2();
        }

        public static void Lesson1_Task1 ()
        {
            Console.WriteLine("Hello world!");
        }

        public static void Lesson1_Task2()
        {
            Console.WriteLine("Enter your name.");
            string user = Console.ReadLine();

            Console.WriteLine($"Hello {user}");
        }

        public static void Lesson2_Task1()
        {
            Console.WriteLine("Enter first number");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter +, -, * or /.");
            char sign = Convert.ToChar(Console.ReadLine());

            double result;

            switch (sign)
            {
                case '+':
                    result = operand1 + operand2;
                    Console.WriteLine($"{operand1} + {operand2} = {result}");
                    break;
                case '-':
                    result = operand1 - operand2;
                    Console.WriteLine($"{operand1} - {operand2} = {result}");
                    break;
                case '*':
                    result = operand1 * operand2;
                    Console.WriteLine($"{operand1} * {operand2} = {result}");
                    break;
                case '/':
                    result = operand1 / operand2;

                    if (operand2 == 0)
                    {
                        Console.WriteLine("You cannot divide it by 0");
                    }
                    else
                    {
                        Console.WriteLine($"{operand1} / {operand2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Unidentified operation");
                    break;
            }
        }

        public static void Lesson2_Task2()
        {
            Console.WriteLine("Enter your number");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number >= 0 && number < 15)  //Less than 15 to include the number 14.5, for example
            {
                Console.WriteLine("Your interval is [0-14]");
            }
            else if (number >= 15 && number < 36) //Less than 36 to include the number 35.5, for example
            {
                Console.WriteLine("Your interval is [15-35]");
            }
            else if (number >= 36 && number < 50)  //Less than 50 to include the number 49.5, for example
            {
                Console.WriteLine("Your interval is [36-49]");
            }
            else if (number >= 50 && number < 101)  //Less than 101 to include the number 100.5, for example
            {
                Console.WriteLine("Your interval is [50-100]");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
        }

        public static void Lesson2_Task3()
        {
            Console.WriteLine("Enter your word with an uppercase letter (Солнечно/Туман/Ветренно/Смог/Дождь/Снег/Метель/Гром/Гроза/Град). ");
            string word = Console.ReadLine();
          
            switch (word)
            {
                case "Солнечно":
                    Console.WriteLine("Sunny");
                    break;
                case "Туман":
                    Console.WriteLine("Fog");
                    break;
                case "Ветренно":
                    Console.WriteLine("Windy");
                    break;
                case "Смог":
                    Console.WriteLine("Smog");
                    break;
                case "Дождь":
                    Console.WriteLine("Rain");
                    break;
                case "Снег":
                    Console.WriteLine("Snow");
                    break;
                case "Метель":
                    Console.WriteLine("Blizzard");
                    break;
                case "Гром":
                    Console.WriteLine("Thunder");
                    break;
                case "Гроза":
                    Console.WriteLine("Thunderstorm");
                    break;
                case "Град":
                    Console.WriteLine("Hailstorm");
                    break;
                default:
                    Console.WriteLine("Unknown word");
                    break;
            }
        }

        public static void Lesson2_Task4_1()
        {
            Console.WriteLine("Enter your number");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
        }

        public static void Lesson2_Task4_2()
        {
            Console.WriteLine("Enter your number");
            double num = Convert.ToDouble(Console.ReadLine());

            int num2 = (int) num / 2;
            
            if (num == num2 * 2)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
        }
    }
}
