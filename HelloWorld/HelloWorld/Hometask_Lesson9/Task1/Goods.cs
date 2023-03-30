 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson9
{
    internal class Goods : Product
    {
        public override string NameOfProduct { get; set; }
        public override double PriceOfProduct { get; set; }
        public override DateTime ProductionDate { get; set; }
        public override double ExpirationDate { get; set; }

        public Goods(string nameOfProduct, double priceOfProduct, DateTime productionDate, double expirationDate) : base(nameOfProduct, priceOfProduct, productionDate, expirationDate)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name of product is {NameOfProduct}. Price is {PriceOfProduct}. Production date is {ProductionDate}. Expiration date is {ExpirationDate} days.");
        }

        public override void CheckExpirationDate()
        {
            if (ProductionDate.AddDays(ExpirationDate) > DateTime.Now)
            {
                Console.WriteLine($"The product is expired. {ProductionDate.AddDays(ExpirationDate)} > {DateTime.Now}");
            }
            else
            {
                Console.WriteLine($"The product is not expired. {ProductionDate.AddDays(ExpirationDate)} < {DateTime.Now}");
            }
        }
    }
}
