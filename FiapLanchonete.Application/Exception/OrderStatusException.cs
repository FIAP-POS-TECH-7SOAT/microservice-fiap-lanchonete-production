using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Application.Exception
{
    internal sealed class OrderStatusException : ApplicationException
    {
        internal OrderStatusException(string message)
                   : base(message)
        { }
    }
}
