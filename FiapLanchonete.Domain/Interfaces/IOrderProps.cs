using FiapLanchonete.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Domain.Interfaces
{
    public interface IOrderProps
    {
        List<Product> Products { get; set; }
        OrderStatus Status { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
