
using CafeNoir.Core;
namespace CafeNoir;


public partial class ProductCategoryForm : Form {
    private string _formName = "Product Categories";

    public CoffeeShop CoffeeShop { get; set; }
    public ProductCategoryForm() {
        InitializeComponent();
    }

    private void ProductCategoryForm_Load(object sender, EventArgs e) {
        this.Text = _formName;
        SetUpBindings();
    }
    #region UI
    private void btnClose_Click(object sender, EventArgs e) {
        CloseForm();
    }
    #endregion

    #region Methods
    private void CloseForm() {
        this.Close();
    }
    private void SetUpBindings() {
        bsCoffeeShop.DataSource = CoffeeShop;

        bsProductCategory.DataSource = bsCoffeeShop;
        bsProductCategory.DataMember = "ProductCats";

        gridControlProductCategories.DataSource = bsProductCategory;
    }
    #endregion
}
