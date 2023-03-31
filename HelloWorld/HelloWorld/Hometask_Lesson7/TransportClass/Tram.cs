using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson7.TransportClass
{
    internal class Tram : Transport
    {
        public Tram(string destination, int transportNumber, string timeOfTransport, int numberOfSeats) : base(destination, transportNumber, timeOfTransport, numberOfSeats)
        {
        }

        public override string Destination { get; set; }
        public override int TransportNumber { get; set; }
        public override string TimeOfTransport { get; set; }
        public override int NumberOfSeats { get; set; }

        public override void TransportType()
        {
            Console.WriteLine("Rail");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This {TransportNumber} tram goes to the {Destination} at {TimeOfTransport} and has {NumberOfSeats} numbers of seats.");
        }
    }
}
