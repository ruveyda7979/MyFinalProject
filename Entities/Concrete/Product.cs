
using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : Audit, IEntitiy
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Category? Category { get; set; }
    }
}
