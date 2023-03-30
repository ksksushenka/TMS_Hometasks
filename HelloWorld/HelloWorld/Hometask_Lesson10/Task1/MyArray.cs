using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson10
{
    internal class MyArray<T>
    {
        public static List<T> arrayList = new List<T>();

        public static void AddToArray(T entity)
        {
            arrayList.Add(entity);
        }

        public static void RemoveFromArray(T entity)
        {
            arrayList.Remove(entity);
        }

        public static void GetElementFromArray(int index)
        {
            Console.WriteLine(arrayList[index]);
        }

        public static void GetLenghtFromArray()
        {
            Console.WriteLine(arrayList.Count);
        }
    }
}
