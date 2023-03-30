using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson10.Task2
{
    internal class Car<T> where T : EngineType
    {
        public T Engine { get; set; }
        public Car (T engine)
        {
            Engine = engine;
        }

        public virtual void Move()
        {
            Console.WriteLine("I can move :)");
        }

        public virtual void Refueling()
        {
            if (Engine.GetType() == typeof(Diesel))
            {
                Console.WriteLine("Diesel");
            }
            else if (Engine.GetType() == typeof(Petrol))
            {
                Console.WriteLine("Petrol");
            }
            else if (Engine.GetType() == typeof(Electro))
            {
                Console.WriteLine("Electro");
            }
            else
            {
                Console.WriteLine("Do not know a type");
            }
        }
    }
}
