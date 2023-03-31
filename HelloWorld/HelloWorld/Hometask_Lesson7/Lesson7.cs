using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Hometasks.Hometask_Lesson7.AutoClass;
using TMS_Hometasks.Hometask_Lesson7.TransportClass;

namespace TMS_Hometasks.Hometask_Lesson7
{
    internal class Lesson7
    {
        public static void Lesson7_task3()
        {
            Transport bus = new Bus("kamenka", 1, "22:30", 20);
            Transport tram = new Tram("malinovka", 20, "20:00", 35);
            Transport trolleybus = new Trolleybus("momo", 123, "15:33", 44);
            Transport undeground = new Underground("oktyabrskaya", 70, "23:59", 101);

            var transports = new Transport[] { bus, tram, trolleybus, undeground };

            foreach (var transport in transports)
            {
                transport.GetInfo();
            }

            Console.WriteLine("\nEnter your destination.");
            string clientDestination = Console.ReadLine();

            foreach (var transport in transports)
            {
                if (clientDestination == transport.Destination)
                {
                    transport.GetInfo();
                }
            }

            Console.WriteLine("\nEnter the time of departure of the transport in format hh:mm.");
            DateTime clientTimeOfTransport = DateTime.Parse(Console.ReadLine());

            foreach (var transport in transports)
            {
                DateTime timeOfTransport = DateTime.Parse(transport.TimeOfTransport);
                if (timeOfTransport >= clientTimeOfTransport)
                {
                    transport.GetInfo();
                }
            }

            bus.PrintTransportType(bus);
            tram.PrintTransportType(tram);
            trolleybus.PrintTransportType(trolleybus);
            undeground.PrintTransportType(undeground);
        }

        public static void Lesson7_task4()
        {
            Auto car = new Car("Mini Cooper", "1234 KK-3", 300, 1650);
            Auto motorbike = new Motorbike("Harley Davidson", "0001 AA-7", 250, 1250, true);
            Auto lorry = new Lorry("Mercedes-Benz", "1234 EE-3", 150, 2000, true);

            var autos = new Auto[] { car, motorbike, lorry };

            foreach (var auto in autos)
            {
                auto.GetInfo();
            }

            Console.WriteLine("Enter the required load capacity.");
            int clientCarrying = Convert.ToInt32(Console.ReadLine());

            foreach (var auto in autos)
            {
                if (clientCarrying <= auto.GetCarryingOfAuto())
                {
                    auto.GetInfo();
                }
            }
        }
    }
}

