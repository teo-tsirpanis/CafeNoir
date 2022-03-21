using CafeNoir.Core;

namespace CafeNoir;
public partial class ProductCategoryDetailsForm : Form
{
    private readonly ProductCategory? _originalProductCategory;
    private ProductCategory? _changedProductCategory;
    private readonly CoffeeShop _coffeeShop;

    public ProductCategoryDetailsForm(CoffeeShop coffeeShop, ProductCategory? productCategory = null)
    {
        _coffeeShop = coffeeShop;
        _originalProductCategory = productCategory?.ShallowCopy();
        _changedProductCategory = productCategory;
        InitializeComponent();
        ControlExtensions.PopulateProductType(ctrlType.Properties);
    }

    private void ProductCategoryDetailsForm_Load(object sender, EventArgs e)
    {
        if (_changedProductCategory == null)
        {
            _changedProductCategory = new ProductCategory();
            _coffeeShop.ProductCats.Add(_changedProductCategory);
            bsProductCategory.DataSource = _changedProductCategory;
        }
        else
        {
            bsProductCategory.DataSource = _changedProductCategory;
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
        ctrlCode.DataBindings.Add(new Binding("EditValue", bsProductCategory, "Code", true));
        ctrlDescription.DataBindings.Add(new Binding("EditValue", bsProductCategory, "Description", true));
        ctrlType.DataBindings.Add(new Binding("EditValue", bsProductCategory, "ProductType", true));
    }

    private void RemoveNewCategory()
    {
        if (_originalProductCategory == null)
        {
            int len = _coffeeShop.ProductCats.Count();
            _coffeeShop.ProductCats.RemoveAt(len - 1);
        }
    }

    private void ReverseChanges()
    {
        if (_originalProductCategory != null && _changedProductCategory != null)
        {
            _changedProductCategory.Code = _originalProductCategory.Code;
            _changedProductCategory.Description = _originalProductCategory.Description;
            _changedProductCategory.ProductType = _originalProductCategory.ProductType;
        }
    }
    #endregion
}
