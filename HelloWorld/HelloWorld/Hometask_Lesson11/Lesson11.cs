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
        public static void Lesson11_task1()
        {
            var sub1 = new Subscriber("test1@mail.com", 10);
            var sub2 = new Subscriber("test2@mail.com", 70);
            var monitor = new PriceMonitor(ShowPrice);

            Notify += sub1.NotifySubscriber;
            Notify += sub2.NotifySubscriber;

            monitor.CheckPrice();
        }
    }
}
