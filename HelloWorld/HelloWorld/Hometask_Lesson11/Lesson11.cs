using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Hometasks.Hometask_Lesson11.Task1;
using static TMS_Hometasks.Hometask_Lesson11.Task1.PriceMonitor;

namespace TMS_Hometasks.Hometask_Lesson11
{
    internal class Lesson11
    {
        public static void ShowPriceMessage(int price)
        {
            Console.WriteLine("Good price.");
        }

        public static void Lesson11_task1()
        {
            Random random = new Random();

            DelegatePriceMonitor nameDelegate = ShowPrice;
            Notify += ShowPriceMessage;

            nameDelegate(random.Next(1, 100));

            PriceMonitor monitor = new PriceMonitor(ShowPrice);
        }
    }
}
