using System;

namespace TMS_Hometasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hometask 1
            Phone apple = new Phone("+375-29-111-11-11", "IPhone 14 Pro Max", 123.45);
            Phone samsung = new Phone("+375-29-222-22-22", "Galaxy S20", 110);
            Phone xiaomi = new Phone("+375-29-333-33-33", "Redmi S10", 150.63);

            apple.GetInfo();
            samsung.GetInfo();
            xiaomi.GetInfo();

            apple.ReceiveCall("Peter");
            samsung.ReceiveCall("Alex");
            xiaomi.ReceiveCall("John");

            string appleNumber = apple.GetNumber(apple.number);
            Console.WriteLine($"Apple number is {appleNumber}.");

            string samsungNumber = apple.GetNumber(samsung.number);
            Console.WriteLine($"Samsung number is {samsungNumber}.");

            string xiaomiNumber = apple.GetNumber(xiaomi.number);
            Console.WriteLine($"Xiaomi number is {xiaomiNumber}.");

            apple.ReceiveCall("Peter", apple.number);
            samsung.ReceiveCall("Alex", samsung.number);
            xiaomi.ReceiveCall("John", xiaomi.number);

            string[] numbers = {apple.number, samsung.number, xiaomi.number};
            Phone.SendMessage(numbers);
            
            //Hometask2
            CreditCard card1 = new CreditCard(111, 120);
            CreditCard card2 = new CreditCard(222, 100.60);
            CreditCard card3 = new CreditCard(333, 2000);

            card1.AddSum(600);
            card2.AddSum(10.40);
            card3.RemoveSum(300);

            card1.GetInfo();
            card2.GetInfo();
            card3.GetInfo();
        }
    }
}
