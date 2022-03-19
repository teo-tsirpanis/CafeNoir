using CafeNoir.Core;
using System.IO;

namespace CafeNoir;

public partial class CoffeeShopForm : Form
{
    private const string FILE_NAME = "coffeeshop.json";
    private CoffeeShop _coffeeshop = null!;

    public CoffeeShopForm()
    {
        InitializeComponent();
    }

    private void CoffeeShopForm_Load(object sender, EventArgs e)
    {
        _coffeeshop = new CoffeeShop(FILE_NAME, out bool createdNew);

        if (createdNew)
        {
            string fullPath = Path.GetFullPath(FILE_NAME);
            MessageBox.Show(this, $"No data file found, created one at '{fullPath}'.", "New data file created.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _coffeeshop.ReloadChanges();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _coffeeshop.SaveChanges();
    }

    private void listToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var customerForm = new CustomerForm(_coffeeshop);
        customerForm.ShowDialog();
    }

    private void productCategoryListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var productCategoryForm = new ProductCategoryForm(_coffeeshop);
        productCategoryForm.ShowDialog();
    }

    //private void listToolStripMenuItem1_Click(object sender, EventArgs e) {

    //    var trans = new Transaction() {
    //        ID = new Guid(),
    //        CustomerID = new Guid(),
    //        EmployeeID = new Guid(),

    //    };
    //    _coffeeshop.Transactions.Add(trans);
    //    var transactionForm = new TransactionForm(_coffeeshop);
    //    transactionForm.ShowDialog();
    //}

    private void coffeeShopStatusToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(this, $"Managers: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Magager)}, " +
            $"Cashiers: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Cashier)}, " +
            $"Baristas: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Barista)}, " +
            $"Waiters: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Waiter)}, " +
            $"Product Categories: {_coffeeshop.ProductCats.Count} "+
            $"Products: {_coffeeshop.Products.Count} "+
            $"Customers: {_coffeeshop.Customers.Count}");
    }


    private void listToolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }

    private void productListToolStripMenuItem_Click(object sender, EventArgs e) {
        var productForm = new ProductForm(_coffeeshop);
        productForm.ShowDialog();
    }
}
