using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson9
{
    internal class SetOfGoods
    {
        public string NameOfSet { get; set; }
        public double PriceOfProduct { get; set; }
        public List<Product> NamesOfGoods { get; set; }


        public SetOfGoods(string nameOfSet, double priceOfProduct, List<Product> namesOfGoods)
        {
            NameOfSet = nameOfSet;
            PriceOfProduct = priceOfProduct;
            NamesOfGoods = namesOfGoods;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name of product is {NameOfSet}. Price is {PriceOfProduct}.");
        }
    }
}
