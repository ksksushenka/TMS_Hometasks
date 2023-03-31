using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson9
{
    internal class Lesson9
    {
        public static void Lesson9_0_1()
        {
            ArrayList list = new ArrayList();

            try
            {
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"An ArgumentOutOfRangeException occurred: {ex.Message}.");
            }
        }

        public static void Lesson9_0_2()
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" }
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Lesson9_1_1()
        {
            DateTime productionDateOfCheese = new DateTime(2023, 3, 20);
            DateTime productionDateOfMilk = new DateTime(2021, 5, 10);
            DateTime productionDateOfButter = new DateTime(2022, 10, 28);

            List<Product> goods = new List<Product>()
            {
               new Goods("Cheese", 10, productionDateOfCheese, 15),
               new Goods("Milk", 5, productionDateOfMilk, 20),
               new Goods("Butter", 2, productionDateOfButter, 100)
            };

            foreach (var product in goods)
            {
                product.GetInfo();
            }

            foreach (var product in goods)
            {
                product.CheckExpirationDate();
            }

            goods[0].PriceOfProduct = goods[0].PriceOfProduct * 100;
            goods.RemoveAt(2);

            Console.WriteLine("After removing the last object.");

            foreach (var product in goods)
            {
                product.GetInfo();
            }

            goods.Clear();
        }

        public static void Lesson9_1_2()
        {
            DateTime productionDateOfCheese = new DateTime(2023, 3, 20);
            DateTime productionDateOfMilk = new DateTime(2021, 5, 10);
            DateTime productionDateOfButter = new DateTime(2022, 10, 28);

            List<Product> goods = new List<Product>()
            {
               new Goods("Cheese", 10, productionDateOfCheese, 15),
               new Goods("Milk", 350, productionDateOfMilk, 20),
               new Goods("Butter", 301, productionDateOfButter, 100),
               new Goods("ChocolateMilk", 450, productionDateOfMilk, 100)
            };

            List<Product> goods2 = new List<Product>();

            for (int i = goods.Count - 1; i >= 0; i--)
            {
                if (goods[i].PriceOfProduct > 300)
                {
                    goods2.Add(goods[i]);
                    goods.Remove(goods[i]);
                }
            }

            Console.WriteLine("Before sort:");

            foreach (var product in goods2)
            {
                product.GetInfo();
            }

            var minValue = goods2[0];

            foreach (var product in goods2)
            {
                if (product.PriceOfProduct < minValue.PriceOfProduct)
                {
                    minValue = product;
                }
            }

            Console.WriteLine(minValue.PriceOfProduct);
        }

        public static void Lesson9_1_3()
        {
            DateTime productionDateOfCheese = new DateTime(2023, 3, 20);
            DateTime productionDateOfMilk = new DateTime(2021, 5, 10);
            DateTime productionDateOfButter = new DateTime(2022, 10, 28);

            var cheese = new Shipment("Cheese", 10, productionDateOfCheese, 15, 22);
            var milk = new Shipment("Milk", 350, productionDateOfMilk, 20, 4);
            var butter = new Shipment("Butter", 301, productionDateOfButter, 100, 80);
            var chocolateMilk = new Shipment("Chocolate Milk", 450, productionDateOfMilk, 100, 33);

            var products = new Dictionary<string, int>()
            {
                {cheese.NameOfProduct, cheese.QuantityOfProduct},
                {milk.NameOfProduct, milk.QuantityOfProduct},
                {butter.NameOfProduct, butter.QuantityOfProduct},
                {chocolateMilk.NameOfProduct, chocolateMilk.QuantityOfProduct}
            };

            foreach (var product in products)
            {
                Console.WriteLine($"Name = {product.Key}, count = {product.Value}.");
            }

            foreach (var product in products)
            {
                Console.WriteLine($"Name = {product.Key}.");
            }

            foreach (var product in products)
            {
                Console.WriteLine($"Count = {product.Value}.");
            }

            var shipments = new List<Shipment>();

            foreach (var product in products)  // Convert Dictionary to List
            {
                var shipment = new Shipment(product.Key, 0, DateTime.Now, 0, product.Value);
                shipments.Add(shipment);
                shipment.GetInfo();
            }

            var ship = new Dictionary<string, int>();

            foreach (var shipment in shipments)  // Convert List to Dictionary
            {
                if (ship.ContainsKey(shipment.NameOfProduct))
                {
                    continue;
                }
                else
                {
                    ship.Add(shipment.NameOfProduct, shipment.QuantityOfProduct);
                }
                Console.WriteLine($"Name: {shipment.NameOfProduct}, count: {ship[shipment.NameOfProduct]}");
            }
        }
    }
}
