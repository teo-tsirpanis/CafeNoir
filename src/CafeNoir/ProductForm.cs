using CafeNoir.Core;
using System;
using System.Linq;

namespace CafeNoir;
public partial class ProductForm : Form
{
    private string _formName = "Products";

    public CoffeeShop CoffeeShop { get; }
    public ProductForm(CoffeeShop coffeeShop)
    {
        CoffeeShop = coffeeShop;
        InitializeComponent();
    }

    private void ProductForm_Load(object sender, EventArgs e)
    {
        Text = _formName;
        //TODO Populate product categories.
        //ControlExtensions.PopulateProductCategories
        SetUpBindings();
    }

    #region UI
    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        OpenDetailsPage();
    }
    private void btnEdit_Click_1(object sender, EventArgs e)
    {
        if (bsProduct.Current is Product product)
            OpenDetailsPage(product);
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (DeletionIsConfirmed())
            DeleteCategory();
    }
    #endregion

    #region Methods
    private void OpenDetailsPage()
    {
        var productDetailsForm = new ProductDetailsForm(CoffeeShop);
        productDetailsForm.ShowDialog();
        grdProduct.RefreshData();
    }
    private void OpenDetailsPage(Product currentProduct)
    {
        var productDetailsForm = new ProductDetailsForm(CoffeeShop, currentProduct);
        productDetailsForm.ShowDialog();
        grdProduct.RefreshData();
    }
    private void SetUpBindings()
    {
        bsCoffeeShop.DataSource = CoffeeShop;
        bsProduct.DataSource = CoffeeShop.Products;
        //bsProduct.DataMember = nameof(CoffeeShop.Products);
        gridControlProduct.DataSource = bsProduct;
    }
    private bool DeletionIsConfirmed()
    {
        if (CoffeeShop.Products.Count < 1)
            return false;
        var result = MessageBox.Show(this, "Are you sure you want to delete the selected Product?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        return result == DialogResult.Yes;
    }

    private void DeleteCategory()
    {
        var prd = bsProduct.Current as Product;
        bsProduct.Remove(prd);
        CoffeeShop.SaveChanges();
    }

    #endregion


}

