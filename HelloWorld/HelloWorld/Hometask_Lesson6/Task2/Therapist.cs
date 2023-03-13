using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson6.Task2
{
    internal class Therapist : Person
    {
        public Therapist(string firstName, string lastName, string post) : base(firstName, lastName, post)
        {
        }

        public override string Treatment()
        {
            return "Treatment plan for the therapist.";
        }

    }
}
