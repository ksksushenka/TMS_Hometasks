using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson9
{
    public abstract class Product 
    {
        public abstract string NameOfProduct { get; set; }
        public abstract double PriceOfProduct { get; set; }
        public abstract DateTime ProductionDate { get; set; }
        public abstract double ExpirationDate { get; set; }

        public Product(string nameOfProduct, double priceOfProduct, DateTime productionDate, double expirationDate)
        {
            NameOfProduct = nameOfProduct;
            PriceOfProduct = priceOfProduct;
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;
        }

        public abstract void GetInfo();

        public abstract void CheckExpirationDate();
    }
}
