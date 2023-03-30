using System;
using TMS_Hometasks.Hometask_Lesson6.Task1;
using TMS_Hometasks.Hometask_Lesson6.Task2;
using TMS_Hometasks.Hometask_Lesson7.Transport;
using TMS_Hometasks.Hometask_Lesson7.Auto;
using TMS_Hometasks.Hometask_Lesson8;
using System.Collections;
using TMS_Hometasks.Hometask_Lesson10;
using TMS_Hometasks.Hometask_Lesson9;
using System.Collections.Generic;

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

            //Figure figure1 = new FigureBuilder().CreateTriangle(3, 4, 5);
            //Figure figure2 = new FigureBuilder().CreateTriangle(4, 4, 5);
            //Figure figure3 = new FigureBuilder().CreateTriangle(5, 5, 5);
            //Figure figure4 = new FigureBuilder().CreateTriangle(4, 2, 3);
            //Figure figure5 = new FigureBuilder().CreateRectangle(2, 3);
            //Figure figure6 = new FigureBuilder().CreateRectangle(3, 3);

            //Console.WriteLine(figure1.GetSquare());
            //Console.WriteLine(figure2.GetSquare());
            //Console.WriteLine(figure3.GetSquare());
            //Console.WriteLine(figure4.GetSquare());
            //Console.WriteLine(figure5.GetSquare());
            //Console.WriteLine(figure6.GetSquare());
            //Console.WriteLine("\n");

            //var figures = new Figure[] {figure1, figure2, figure3, figure4, figure5, figure6};

            //foreach (var figure in figures)
            //{
            //    Console.WriteLine(figure.GetSquare());
            //}

            ////Hometask2_Lesson6

            //Person patient = new Patient("Alex", "Ivanov", "patient");
            //Person doctor = new TreatmentPlan().GetTreatmentPlan("Ivan", "Petrov", "surgeon", 1);

            //Console.WriteLine($"{patient.firstName} {patient.lastName} your doctor is {doctor.post} {doctor.firstName} {doctor.lastName}. {doctor.Treatment()}");

            ////Lesson7_task3
            //Transport bus = new Bus("kamenka", 1, "22:30", 20);
            //Transport tram = new Tram("malinovka", 20, "20:00", 35);
            //Transport trolleybus = new Trolleybus("momo", 123, "15:33", 44);
            //Transport undeground = new Underground("oktyabrskaya", 70, "23:59", 101);

            //var transports = new Transport[] { bus, tram, trolleybus, undeground };

            //foreach (var transport in transports)
            //{
            //    transport.GetInfo();
            //}

            //Console.WriteLine("\nEnter your destination.");
            //string clientDestination = Console.ReadLine();

            //foreach (var transport in transports)
            //{
            //    if (clientDestination == transport.Destination)
            //    {
            //        transport.GetInfo();
            //    }
            //}

            //Console.WriteLine("\nEnter the time of departure of the transport in format hh:mm.");
            //DateTime clientTimeOfTransport = DateTime.Parse(Console.ReadLine());

            //foreach (var transport in transports)
            //{
            //    DateTime timeOfTransport = DateTime.Parse(transport.TimeOfTransport);
            //    if (timeOfTransport >= clientTimeOfTransport)
            //    {
            //        transport.GetInfo();
            //    }
            //}

            //bus.PrintTransportType(bus);
            //tram.PrintTransportType(tram);
            //trolleybus.PrintTransportType(trolleybus);
            //undeground.PrintTransportType(undeground);

            ////Lesson7_task4

            //Auto car = new Car("Mini Cooper", "1234 KK-3", 300, 1650);
            //Auto motorbike = new Motorbike("Harley Davidson", "0001 AA-7", 250, 1250, true);
            //Auto lorry = new Lorry("Mercedes-Benz", "1234 EE-3", 150, 2000, true);

            //var autos = new Auto[] { car, motorbike, lorry };

            //foreach (var auto in autos)
            //{
            //    auto.GetInfo();
            //}

            //Console.WriteLine("Enter the required load capacity.");
            //int clientCarrying = Convert.ToInt32(Console.ReadLine());

            //foreach (var auto in autos)
            //{
            //    if (clientCarrying <= auto.GetCarryingOfAuto())
            //    {
            //        auto.GetInfo();
            //    }
            //}
            
            ////Lesson8_task1
            //Lesson8_task1

            //try
            //{
            //    Login.LogIn("sa d", "mdlkwq", "mdlks1wq");      //incorrect login
            //}
            //catch (WrongLoginException wrongLoginEx)
            //{
            //    Console.WriteLine(wrongLoginEx.Message);
            //}
            //catch (WrongPasswordException wrongPasswordEx)
            //{
            //    Console.WriteLine(wrongPasswordEx.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Login.LogIn("sad", "mdnskjdwq", "mdlks1wq");     //incorrect password
            //}
            //catch (WrongLoginException wrongLoginEx)
            //{
            //    Console.WriteLine(wrongLoginEx.Message);
            //}
            //catch (WrongPasswordException wrongPasswordEx)
            //{
            //    Console.WriteLine(wrongPasswordEx.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Login.LogIn("sad", "md1lkwq", "md1kwq");     //incorrect confirmPassword
            //}
            //catch (WrongLoginException wrongLoginEx)
            //{
            //    Console.WriteLine(wrongLoginEx.Message);
            //}
            //catch (WrongPasswordException wrongPasswordEx)
            //{
            //    Console.WriteLine(wrongPasswordEx.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Login.LogIn("sad", "mdlkwq", "mdlkwq");    //correct data
            //}
            //catch (WrongLoginException wrongLoginEx)
            //{
            //    Console.WriteLine(wrongLoginEx.Message);
            //}
            //catch (WrongPasswordException wrongPasswordEx)
            //{
            //    Console.WriteLine(wrongPasswordEx.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Lesson10_Task1.Lesson10_task1();

            Lesson10_Task2.Lesson10_task2();

            Lesson10_Task3.Lesson10_task3();
            
            //Lesson9_0.Lesson9_0_1();

            //Lesson9_0.Lesson9_0_2();

            //Lesson9_1.Lesson9_1_1();

            //Lesson9_1.Lesson9_1_2();

            Lesson9_1.Lesson9_1_3();














            //var cheeses = new Shipment("Cheese", 10, productionDateOfCheese, 20, 10);


            //var setOfProducts = new SetOfGoods("set of dairy products", 30, goods);

            //cheese.GetInfo();
            //cheese.CheckExpirationDate();

            //cheeses.GetInfo();
            //cheeses.CheckExpirationDate();

            //setOfProducts.GetInfo();
        }
    }
}
