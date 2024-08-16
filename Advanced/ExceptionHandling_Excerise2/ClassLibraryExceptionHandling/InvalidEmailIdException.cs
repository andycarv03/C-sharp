using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InvalidEmailIdException : Exception
    {
        public InvalidEmailIdException(string message) : base(message)
        {}
    }
}
