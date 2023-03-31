using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson7.TransportClass
{
    public abstract class Transport : ITransportService
    {
        public abstract string Destination { get; set; }
        public abstract int TransportNumber { get; set; }
        public abstract string TimeOfTransport { get; set; }
        public abstract int NumberOfSeats { get; set; }
            
        public Transport(string destination, int transportNumber, string timeOfTransport, int numberOfSeats)
        {
            Destination = destination;
            TransportNumber = transportNumber;
            TimeOfTransport = timeOfTransport;
            NumberOfSeats = numberOfSeats;

        }

        public abstract void TransportType();
        public abstract void GetInfo();

        public void PrintTransportType(Transport transport)
        {
            transport.TransportType();
        }
    }
}
