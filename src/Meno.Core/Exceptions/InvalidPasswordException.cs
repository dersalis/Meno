using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meno.Core.Exceptions
{
    public sealed class InvalidPasswordException : BaseException
    {
        public InvalidPasswordException() : base("Invalid password.")
        {
        }
    }
}