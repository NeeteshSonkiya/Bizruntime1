using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    class ExceptionEx10
    {
        static void Main(string[] args)
        {
            throw new AgeNotValidException("Age should be 18 or greater then 18 year ");
        }
    }
    class AgeNotValidException : Exception
    {
        public AgeNotValidException()
            :base()
        {

        }
        public AgeNotValidException(string message)
            :base(message)
        {

        }
    }
}
