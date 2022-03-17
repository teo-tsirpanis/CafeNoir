
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

    }
}
