
using CafeNoir.Core;
using System.IO;
using System.Text.Json;

namespace CafeNoir;
public partial class ProductCategoryForm : Form {
    private string _formName = "Product Categories";

    public CoffeeShop CoffeeShop { get; set; }
    private string FILE_NAME;
    public ProductCategoryForm(string file_name) {
        FILE_NAME = file_name;
        InitializeComponent();
    }

    private void ProductCategoryForm_Load(object sender, EventArgs e) {
        this.Text = _formName;
        PopulateControls();
        SetUpBindings();
    }
    #region UI
    private void btnClose_Click(object sender, EventArgs e) {
        CloseForm();
    }
    private void btnNew_Click(object sender, EventArgs e) {
        OpenDetailsPage();
    }
    private void btnEdit_Click(object sender, EventArgs e) {
        OpenDetailsPage(bsProductCategory.Current as ProductCategory);
    }
    private void btnDelete_Click(object sender, EventArgs e) {
        if (DeletionIsConfirmed())
            DeleteCategory();
    }
    #endregion

    #region Methods

    private void OpenDetailsPage() {
        var coffeeShop = bsCoffeeShop.Current as CoffeeShop;
        var productCategoryDetailsForm = new ProductCategoryDetailsForm(coffeeShop, FILE_NAME);
        productCategoryDetailsForm.ShowDialog();
        grdProductCategories.RefreshData();
    }
    private void OpenDetailsPage(ProductCategory currentProductCategory) {
        if (currentProductCategory != null) {
            var coffeeShop = bsCoffeeShop.Current as CoffeeShop;
            var productCategoryDetailsForm = new ProductCategoryDetailsForm(coffeeShop, FILE_NAME, currentProductCategory);
            productCategoryDetailsForm.ShowDialog();
            grdProductCategories.RefreshData();
        }
    }
    private void CloseForm() {
        this.Close();
    }
    private void SetUpBindings() {
        bsCoffeeShop.DataSource = CoffeeShop;

        bsProductCategory.DataSource = bsCoffeeShop;
        bsProductCategory.DataMember = "ProductCats";

        gridControlProductCategories.DataSource = bsProductCategory;
    }
    private bool DeletionIsConfirmed() {
        if (CoffeeShop.ProductCats.Count < 1)
            return false;
        var result = MessageBox.Show(this, "Are you sure you want to delete the selected Category?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        return (result == DialogResult.Yes) ;
    }
    private void DeleteCategory() {
        var student = bsProductCategory.Current as ProductCategory;
        bsProductCategory.Remove(student);
        SaveData();
    }
    private void SaveData() {
        var coffeeShop = bsCoffeeShop.Current as CoffeeShop;
        string json = JsonSerializer.Serialize(coffeeShop);
        File.WriteAllText(FILE_NAME, json);
    }
    private void PopulateControls() {
        var controlsHelper = new ControlsHelper();
        controlsHelper.PopulateProductType(repType);
    }
    #endregion

}
