using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class Person
    {
        public string firstName;
        public string lastName;
        public string post;
        public int number;

        public Person(string firstName, string lastName, string post)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.post = post;
        }

        public Person() { }

        public virtual string Treatment()
        {
            return "We don't know how to treat you.";
        }
    }
}
