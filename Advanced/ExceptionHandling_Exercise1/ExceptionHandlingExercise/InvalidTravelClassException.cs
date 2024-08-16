using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    public class InvalidTravelClassException : Exception
    {
        public InvalidTravelClassException() 
        {}
        public InvalidTravelClassException(string message) : base (message) 
        {}
    }
}
