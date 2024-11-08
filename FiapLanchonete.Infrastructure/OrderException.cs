using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Infrastructure
{
    using System;
    public class OrderException : Exception
    {
        internal OrderException(string businessMessage)
               : base(businessMessage)
        {
        }
    }
}
