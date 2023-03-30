using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson10
{
    internal class Lesson10_Task1
    {
        public static void Lesson10_task1()
        {
            MyArray<string>.AddToArray("spring");
            MyArray<string>.AddToArray("summer");
            MyArray<string>.RemoveFromArray("spring");
            MyArray<string>.GetElementFromArray(0);
            MyArray<string>.GetLenghtFromArray();
        }
    }
}
