using CafeNoir.Core;
using System;

namespace CafeNoir;
public partial class ProductDetailsForm1 : Form
{
  
    public Product Product { get; set; }
    public Product _originalProduct;
    public CoffeeShop _coffeeShop;
    public ProductDetailsForm1(CoffeeShop coffeeShop, Product? product) {
        
        _coffeeShop = coffeeShop;

        if (product == null) {

            Product = new Product();
            _coffeeShop.Products.Add(Product);
        }



        //_changedProduct = product;
        //_originalProduct = product?.ShallowCopy();
        InitializeComponent();
    }
    private void ProductDetailsForm_Load(object sender, EventArgs e)
    {
        bindingSource1.DataSource = Product;

        SetDataBindings();
    }


    #region UI
    private void btnSave_Click(object sender, EventArgs e)
    {
        _coffeeShop.SaveChanges();
        Close();
    }
    private void btnCancel_Click(object sender, EventArgs e)
    {
        //ReverseChanges();
        RemoveNewCategory();
        Close();
    }

    #endregion

    #region Methods
    private void SetDataBindings()
    {

        ctrlCode.DataBindings.Add(new Binding("EditValue", bindingSource1, "Code", true));
        ctrlDescription.DataBindings.Add(new Binding("EditValue", bindingSource1, "Description", true));
        ctrlProductCategoryID.DataBindings.Add("EditValue", bindingSource1, "ProductCategoryID", true);
        calcEditCost.DataBindings.Add(new Binding("EditValue", bindingSource1, "Cost", true ));
        calcEditPrice.DataBindings.Add(new Binding("EditValue", bindingSource1, "Price", true));
    }
    private void RemoveNewCategory()
    {
        if (_originalProduct == null)
        {
            int len = _coffeeShop.Products.Count();
            _coffeeShop.Products.RemoveAt(len - 1);
        }
    }

    //private void ReverseChanges()
    //{
    //    if (_originalProduct != null && _changedProduct != null)
    //    {
    //        _changedProduct.Code = _originalProduct.Code;
    //        _changedProduct.Description = _originalProduct.Description;
    //        _changedProduct.Price = _originalProduct.Price;
    //        _changedProduct.Cost = _originalProduct.Cost;
    //    }
    //}

}

#endregion

