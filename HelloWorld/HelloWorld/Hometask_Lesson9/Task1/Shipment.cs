using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson9
{
    internal class Shipment : Product
    {
        public override string NameOfProduct { get; set; }
        public override double PriceOfProduct { get; set; }
        public override DateTime ProductionDate { get; set; }
        public override double ExpirationDate { get; set; }
        public int QuantityOfProduct{ get; set; }

        public Shipment(string nameOfProduct, double priceOfProduct, DateTime productionDate, double expirationDate, int quantityOfProduct) : base(nameOfProduct, priceOfProduct, productionDate, expirationDate)
        {
            QuantityOfProduct = quantityOfProduct;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"It is shipment of {NameOfProduct}. A quantity is {QuantityOfProduct}. Price is {PriceOfProduct}. Production date is {ProductionDate}. Expiration date is {ExpirationDate} days.");
        }

        public override void CheckExpirationDate()
        {
            if (ProductionDate.AddDays(ExpirationDate) > DateTime.Now)
            {
                Console.WriteLine("The product is expired.");
            }
            else
            {
                Console.WriteLine("The product is not expired.");
            }
        }
    }
}
