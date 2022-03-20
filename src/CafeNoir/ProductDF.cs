using CafeNoir.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeNoir {
    public partial class ProductDF : Form {

        public Product Product { get; set; }
        public Product _originalProduct;
        public CoffeeShop CoffeeShop { get; set; }

        public ProductDF(CoffeeShop coffeeShop, Product? product) {
            CoffeeShop = coffeeShop;

            if (product == null) {
                Product = new Product();
                CoffeeShop.Products.Add(Product);
            }
            else {
                _originalProduct = product.ShallowCopy();
                Product = product;
            }

            InitializeComponent();
        }

        private void ProductDF_Load(object sender, EventArgs e) {

            bsProduct.DataSource = Product;
            bsProductCategoryID.DataSource = CoffeeShop.ProductCats;
            grdProductCategoryID.DataSource = bsProductCategoryID;

            textEditCode.DataBindings.Add("EditValue", bsProduct, "Code");
            textEditDescription.DataBindings.Add("EditValue",bsProduct,"Description");
            calcEditCost.DataBindings.Add("EditValue", bsProduct, "Cost");
            calcEditPrice.DataBindings.Add("EditValue", bsProduct, "Price");

        }

        private void simpleButtonSave_Click(object sender, EventArgs e) {

            if(bsProductCategoryID.Current == null) {
                MessageBox.Show("Pick a product category!");
                return;
            }
            var productCategory = bsProductCategoryID.Current as ProductCategory;
            Product.ProductCategoryID = productCategory.ID;

            CoffeeShop.SaveChanges();
            this.Close();
        }

        private void bsProductCategoryID_CurrentChanged(object sender, EventArgs e) {

        }

        private void simpleButtonClose_Click(object sender, EventArgs e) {
            if (_originalProduct != null) {
                Product.ProductCategoryID = _originalProduct.ProductCategoryID;
                Product.Code = _originalProduct.Code;
                Product.Description = _originalProduct.Description;
                Product.Price = _originalProduct.Price;
                Product.Cost = _originalProduct.Cost;
            }
            else {
                CoffeeShop.Products.Remove(Product);
            }

            Close();
        }
    }
}
