using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapLanchonete.Infrastructure.MongoDataAccess.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public string Category { get; private set; }

    }
}
