using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class Surgeon : Person
    {
        public Surgeon(string firstName, string lastName, string post) : base(firstName, lastName, post)
        {
        }

        public override string Treatment()
        {
            return "Treatment plan for the surgeon.";
        }

    }
}
