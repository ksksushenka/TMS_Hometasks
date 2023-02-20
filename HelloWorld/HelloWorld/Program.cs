using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Console.WriteLine("Введите ваше имя");

            string user = Console.ReadLine();

            Console.WriteLine($"Hello {user}");

        }
    }
}
