using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson11.Task1
{
    internal class Subscriber
    {
        public string Email { get; set; }
        public int ExpectedPrice { get; set; }

        public Subscriber(string email, int expectedPrice)
        {
            Email = email;
            ExpectedPrice = expectedPrice;
        }

        public void NotifySubscriber(int price)
        {
            if (price < ExpectedPrice)
            {
                Console.WriteLine($"Email sent to {Email}. Current price is {price}. It is a good price.");
            }
        }
    }
}
