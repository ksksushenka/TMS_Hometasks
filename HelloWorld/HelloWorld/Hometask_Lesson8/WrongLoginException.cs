using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson8
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException() { }

        public WrongLoginException(string message) : base(message) { }
    }
}
