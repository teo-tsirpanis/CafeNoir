
using CafeNoir.Core;
using DevExpress.XtraEditors.Controls;
using System.IO;
using System.Text.Json;

namespace CafeNoir;
public partial class ProductCategoryDetailsForm : Form {
    private string FILE_NAME;
    private string _formName = "New Product Category";

    private ProductCategory _changedProductCategory;
    private ProductCategory _originalProductCategory;
    private CoffeeShop _coffeeShop;

    public ProductCategoryDetailsForm(CoffeeShop university, string file_name) {
        InitializeComponent();
        this.Text = _formName;
        FILE_NAME = file_name;
        _coffeeShop = university;
        PopulateControls();
    }

    public ProductCategoryDetailsForm(CoffeeShop coffeeShop, string file_name, ProductCategory productCategory) : this(coffeeShop, file_name) {
        _changedProductCategory = productCategory;
        _originalProductCategory = productCategory.ShallowCopy();
    }

    private void ProductCategoryDetailsForm_Load(object sender, EventArgs e) {
        if (_changedProductCategory == null) {
            _changedProductCategory = new ProductCategory();
            _coffeeShop.ProductCats.Add(_changedProductCategory);
            bsProductCategory.DataSource = _changedProductCategory;
        }
        else {
            bsProductCategory.DataSource = _changedProductCategory;
        }

        SetDataBindings();
    }
    #region UI
    private void btnSave_Click(object sender, EventArgs e) {
        SaveToFile();
        DialogResult = DialogResult.OK;
    }
    private void btnCancel_Click(object sender, EventArgs e) {
        ReverseChanges();
        RemoveNewCategory();
        this.Close();
    }
    #endregion

    #region Methods
    private void SetDataBindings() {
        ctrlCode.DataBindings.Add(new Binding("EditValue", bsProductCategory, "Code", true));
        ctrlDescription.DataBindings.Add(new Binding("EditValue", bsProductCategory, "Description", true));
        ctrlType.DataBindings.Add(new Binding("EditValue", bsProductCategory, "ProductType", true));
    }
    private void SaveToFile() {
        string json = JsonSerializer.Serialize(_coffeeShop);
        File.WriteAllText(FILE_NAME, json);
    }
    private void RemoveNewCategory() {
        if (_originalProductCategory == null) {
            int len = _coffeeShop.ProductCats.Count();
            _coffeeShop.ProductCats.RemoveAt(len - 1);
        }
    }
    private void ReverseChanges() {
        if (_originalProductCategory != null) {
            _changedProductCategory.Code = _originalProductCategory.Code;
            _changedProductCategory.Description = _originalProductCategory.Description;
            _changedProductCategory.ProductType = _originalProductCategory.ProductType;
        }
    }
    private void PopulateControls() {
        var controlsHelper = new ControlsHelper();
        controlsHelper.PopulateProductType(ctrlType.Properties);
    }
    #endregion




}
