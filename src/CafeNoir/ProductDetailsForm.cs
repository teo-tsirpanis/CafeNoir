using CafeNoir.Core;
using System;

namespace CafeNoir;
public partial class ProductDetailsForm : Form
{
    private Product? _changedProduct;
    private Product? _originalProduct;
    private readonly CoffeeShop _coffeeShop;
    public ProductDetailsForm(CoffeeShop coffeeShop, Product? product = null)
    {
        _coffeeShop = coffeeShop;
        _changedProduct = product;
        _originalProduct = product?.ShallowCopy();
        InitializeComponent();
    }
    private void ProductDetailsForm_Load(object sender, EventArgs e)
    {
        if (_changedProduct == null)
        {
            _changedProduct = new Product();
            _coffeeShop.Products.Add(_changedProduct);
            bsProduct.DataSource = _changedProduct;
        }
        else
        {
            bsProduct.DataSource = _changedProduct;
        }

        SetDataBindings();
    }


    #region UI
    private void btnSave_Click(object sender, EventArgs e)
    {
        _coffeeShop.SaveChanges();
        DialogResult = DialogResult.OK;
    }
    private void btnCancel_Click(object sender, EventArgs e)
    {
        ReverseChanges();
        RemoveNewCategory();
        Close();
    }

    #endregion

    #region Methods
    private void SetDataBindings()
    {
        ctrlCode.DataBindings.Add(new Binding("EditValue", bsProduct, "Code", true));
        ctrlDescription.DataBindings.Add(new Binding("EditValue", bsProduct, "Description", true));
        ctrlProductCategoryID.DataBindings.Add(new Binding("EditValue", bsProduct, "Product Category", true));
        ctrlPrice.DataBindings.Add(new Binding("EditValue", bsProduct, "Price", true));
        ctrlCost.DataBindings.Add(new Binding("EditValue", bsProduct, "Cost", true));
    }
    private void RemoveNewCategory()
    {
        if (_originalProduct == null)
        {
            int len = _coffeeShop.Products.Count();
            _coffeeShop.Products.RemoveAt(len - 1);
        }
    }

    private void ReverseChanges()
    {
        if (_originalProduct != null && _changedProduct != null)
        {
            _changedProduct.Code = _originalProduct.Code;
            _changedProduct.Description = _originalProduct.Description;
            _changedProduct.Price = _originalProduct.Price;
            _changedProduct.Cost = _originalProduct.Cost;
        }
    }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
    {

    }
}

#endregion

