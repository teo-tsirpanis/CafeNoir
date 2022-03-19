using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeNoir.Core;

public class Product
{
    public Guid ID { get; } = Guid.NewGuid();
    public string Code { get; set; }
    public Guid ProductCategoryID { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal Cost { get; set; }
    public Product ShallowCopy()
    {
        return (Product)MemberwiseClone();
    }


    public Product(Guid productCategoryID)
    {
        ProductCategoryID = productCategoryID;
    }
    public Product(string code, Guid productCategoryID, string description, decimal price, decimal cost)
    {
        Code = code;
        ProductCategoryID = productCategoryID;
        Description = description;
        Price = price;
        Cost = cost;
    }
    public Product()
    {

        public Guid ID { get; set; }

        public string Code { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
        public string Description { get; set; }
        public Guid ProductCategoryID { get; set; }

        // TODO: Figure out how to implement the category reference.

        public Product()
        {
            ID = Guid.NewGuid();
        }

    }
}
