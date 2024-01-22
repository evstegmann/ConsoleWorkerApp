using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException()
        {

        }

        public DomainException(string message) : base(message)
        {

        }

    }
}
