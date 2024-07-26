using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : IEntitiy
    {
        public int Id { get; set; }
        public string ContactName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
