using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson7.TransportClass
{
    internal class Bus : Transport
    {
        public Bus(string destination, int transportNumber, string timeOfTransport, int numberOfSeats) : base(destination, transportNumber, timeOfTransport, numberOfSeats)
        {
        }

        public override string Destination { get; set; }
        public override int TransportNumber { get; set; }
        public override string TimeOfTransport { get; set; }
        public override int NumberOfSeats { get; set; }

        public override void TransportType()
        {
            Console.WriteLine("Diesel");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This {TransportNumber} bus goes to the {Destination} at {TimeOfTransport} and has {NumberOfSeats} numbers of seats.");
        }
    }
}
