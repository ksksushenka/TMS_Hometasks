using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson11.Task1
{
    internal class PriceMonitor
    {
        public delegate void DelegatePriceMonitor(int price);
        public static event DelegatePriceMonitor Notify;

        public PriceMonitor(DelegatePriceMonitor delegatePriceMonitor) 
        {
        }

        public static void ShowPrice(int price)
        {
            if (price < 10)
            {
                Notify(price);
            }

            Console.WriteLine($"Average price is {price}.");
        }
    }
}
