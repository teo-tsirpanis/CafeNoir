using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeNoir.Core
{
    public class Product
    {

        public Guid ID { get; set; }

        public string Code { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        // TODO: Figure out how to implement the category reference.

        public Product()
        {
            ID = Guid.NewGuid();
        }
    }
}
