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
        private DelegatePriceMonitor nameDelegate;

        public int Price { get; set; }

        Random random = new Random();

        public PriceMonitor(DelegatePriceMonitor delegatePriceMonitor) 
        {
            Price = random.Next(1, 100);
            nameDelegate = delegatePriceMonitor;
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"Average price is {price}.");
        }

        public void CheckPrice()
        {
            nameDelegate?.Invoke(Price);
            Notify?.Invoke(Price);
        }
    }
}
