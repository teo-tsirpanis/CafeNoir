using CafeNoir.Core;

namespace CafeNoir;
public partial class ProductCategoryForm : Form
{
    private string _formName = "Product Categories";

    public CoffeeShop CoffeeShop { get; }
    public ProductCategoryForm(CoffeeShop coffeeShop)
    {
        CoffeeShop = coffeeShop;
        InitializeComponent();
    }

    private void ProductCategoryForm_Load(object sender, EventArgs e)
    {
        Text = _formName;
        ControlExtensions.PopulateProductType(repType);
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

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (bsProductCategory.Current is ProductCategory productCategory)
            OpenDetailsPage(productCategory);
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
        var productCategoryDetailsForm = new ProductCategoryDetailsForm(CoffeeShop);
        productCategoryDetailsForm.ShowDialog();
        grdProductCategories.RefreshData();
    }

    private void OpenDetailsPage(ProductCategory currentProductCategory)
    {
        var productCategoryDetailsForm = new ProductCategoryDetailsForm(CoffeeShop, currentProductCategory);
        productCategoryDetailsForm.ShowDialog();
        grdProductCategories.RefreshData();
    }

    private void SetUpBindings()
    {
        bsCoffeeShop.DataSource = CoffeeShop;

        bsProductCategory.DataSource = bsCoffeeShop;
        bsProductCategory.DataMember = "ProductCats";

        gridControlProductCategories.DataSource = bsProductCategory;
    }

    private bool DeletionIsConfirmed()
    {
        if (CoffeeShop.ProductCats.Count < 1)
            return false;
        var result = MessageBox.Show(this, "Are you sure you want to delete the selected Category?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        return result == DialogResult.Yes;
    }

    private void DeleteCategory()
    {
        var student = bsProductCategory.Current as ProductCategory;
        bsProductCategory.Remove(student);
        CoffeeShop.SaveChanges();
    }
    #endregion
}
