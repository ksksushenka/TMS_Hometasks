using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class TreatmentPlan
    {
        public TreatmentPlan() { }

        public Person GetTreatmentPlan(string firstName, string lastName, string post, int number)
        {
            if (number == 1)
            {
                return new Surgeon(firstName, lastName, post);
            }
            else if (number == 2)
            {
                return new Dentist(firstName, lastName, post);
            }
            else
            {
                return new Therapist(firstName, lastName, post);
            }
        }
    }
}
