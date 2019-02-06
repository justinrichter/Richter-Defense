using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter_Defense
{
    class RichterDefenseException : System.Exception //Inheriting System.Exception
{
    public RichterDefenseException()
    {
    }

    public RichterDefenseException(string message) : base(message)
    {
    }
}

    class OutOfBoundsException : RichterDefenseException  //Inheriting System.Exception AND RichterDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}