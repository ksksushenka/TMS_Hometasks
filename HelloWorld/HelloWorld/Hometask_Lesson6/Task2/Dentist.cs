using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class Dentist : Person
    {
        public Dentist(string firstName, string lastName, string post) : base(firstName, lastName, post)
        {
        }

        public override string Treatment()
        {
            return "Treatment plan for the dentist.";
        }

    }
}
