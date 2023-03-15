using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson7.Auto
{
    abstract class Auto
    {
        public abstract string ModelOfAuto { get; set; }
        public abstract string NumberOfAuto { get; set; }
        public abstract int SpeedOfAuto { get; set; }
        public abstract int CarryingOfAuto { get; set; }

        public Auto(string modelOfAuto, string numberOfAuto, int speedOfAuto, int carryingOfAuto)
        {
            ModelOfAuto = modelOfAuto;
            NumberOfAuto = numberOfAuto;
            SpeedOfAuto = speedOfAuto;
            CarryingOfAuto = carryingOfAuto;
        }

        public abstract void GetInfo();

        public abstract int GetCarryingOfAuto();


    }
}
