using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaSaque.entities.Exceptions
{
    public class DomainException: ApplicationException
    {
        public DomainException(string message) :base (message)
        {

        }
    }
}