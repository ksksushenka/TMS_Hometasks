using System;

namespace TMS_Hometasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Hometask 1_Lesson5
            //Phone apple = new Phone("+375-29-111-11-11", "IPhone 14 Pro Max", 123.45);
            //Phone samsung = new Phone("+375-29-222-22-22", "Galaxy S20", 110);
            //Phone xiaomi = new Phone("+375-29-333-33-33", "Redmi S10", 150.63);

            //apple.GetInfo();
            //samsung.GetInfo();
            //xiaomi.GetInfo();

            //apple.ReceiveCall("Peter");
            //samsung.ReceiveCall("Alex");
            //xiaomi.ReceiveCall("John");

            //string appleNumber = apple.GetNumber(apple.number);
            //Console.WriteLine($"Apple number is {appleNumber}.");

            //string samsungNumber = apple.GetNumber(samsung.number);
            //Console.WriteLine($"Samsung number is {samsungNumber}.");

            //string xiaomiNumber = apple.GetNumber(xiaomi.number);
            //Console.WriteLine($"Xiaomi number is {xiaomiNumber}.");

            //apple.ReceiveCall("Peter", apple.number);
            //samsung.ReceiveCall("Alex", samsung.number);
            //xiaomi.ReceiveCall("John", xiaomi.number);

            //string[] numbers = {apple.number, samsung.number, xiaomi.number};
            //Phone.SendMessage(numbers);

            ////Hometask2_Lesson5
            //CreditCard card1 = new CreditCard(111, 120);
            //CreditCard card2 = new CreditCard(222, 100.60);
            //CreditCard card3 = new CreditCard(333, 2000);

            //card1.AddSum(600);
            //card2.AddSum(10.40);
            //card3.RemoveSum(300);

            //card1.GetInfo();
            //card2.GetInfo();
            //card3.GetInfo();

            //Hometask1_Lesson6

            Figure figure1 = new FigureBuilder().CreateTriangle(3, 4, 5);
            Figure figure2 = new FigureBuilder().CreateTriangle(4, 4, 5);
            Figure figure3 = new FigureBuilder().CreateTriangle(5, 5, 5);
            Figure figure4 = new FigureBuilder().CreateTriangle(4, 2, 3);
            Figure figure5 = new FigureBuilder().CreateRectangle(2, 3);
            Figure figure6 = new FigureBuilder().CreateRectangle(3, 3);

            Console.WriteLine(figure1.GetSquare());
            Console.WriteLine(figure2.GetSquare());
            Console.WriteLine(figure3.GetSquare());
            Console.WriteLine(figure4.GetSquare());
            Console.WriteLine(figure5.GetSquare());
            Console.WriteLine(figure6.GetSquare());
            Console.WriteLine("\n");

            var figures = new Figure[] {figure1, figure2, figure3, figure4, figure5, figure6};

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetSquare());
            }

            //Hometask2_Lesson6

            Person patient = new Patient("Alex", "Ivanov", "patient");
            Person doctor = new TreatmentPlan().GetTreatmentPlan("Ivan", "Petrov", "surgeon", 1);

            Console.WriteLine($"{patient.firstName} {patient.lastName} your doctor is {doctor.post} {doctor.firstName} {doctor.lastName}. {doctor.Treatment()}");
        }
    }
}
