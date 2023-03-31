using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson7.AutoClass
{
    internal class Motorbike : Auto
    {
        public override string ModelOfAuto { get ; set ; }
        public override string NumberOfAuto { get; set; }
        public override int SpeedOfAuto { get; set; }
        public override int CarryingOfAuto { get; set; }
        bool sideCar;

        public Motorbike(string modelOfAuto, string numberOfAuto, int speedOfAuto, int carryingOfAuto, bool sidecar) : base(modelOfAuto, numberOfAuto, speedOfAuto, carryingOfAuto)
        {
            this.sideCar = sidecar;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This is a {ModelOfAuto}, the number is {NumberOfAuto}, the max speed is {SpeedOfAuto}, the carrying is {GetCarryingOfAuto()}.");
        }

        public override int GetCarryingOfAuto()
        {
            if (sideCar)
            {
                return CarryingOfAuto * 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
