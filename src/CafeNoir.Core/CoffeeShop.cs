using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeNoir.Core {
    public class CoffeeShop {

   
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<ProductCategory> ProductCats { get; set; } = new List<ProductCategory>();
        public List<Employee> Employess { get; set; } = new List<Employee>();

        public CoffeeShop() {

        }


    }
}
