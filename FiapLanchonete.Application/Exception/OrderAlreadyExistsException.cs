using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Exception
{
    internal sealed class OrderAlreadyExistsException : ApplicationException
    {
        internal OrderAlreadyExistsException(string message)
                   : base(message)
        { }
    }
}
