using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Infrastructure
{
    using System;
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage)
               : base(businessMessage)
        {
        }
    }
}
