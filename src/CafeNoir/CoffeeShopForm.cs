using CafeNoir.Core;
using System.IO;
using System.Text.Json;

namespace CafeNoir;

public partial class CoffeeShopForm : Form {
    private const string FILE_NAME = "coffeeshop.json";
    private CoffeeShop _coffeeshop;

    public CoffeeShopForm() {
        InitializeComponent();
    }
    private void CoffeeShopForm_Load(object sender, EventArgs e) {

        
        saveToolStripMenuItem.Enabled = false;
        newDayToolStripMenuItem.Enabled = false;
        todaysCustomerToolStripMenuItem.Enabled = false;
        coffeeShopStatusToolStripMenuItem.Enabled=false;
        


        //CoffeeShop cf = new CoffeeShop();
        //Customer c = new Customer("001");
        //Product p = new Product();
        //ProductCategory pc = new ProductCategory();
        //Employee em = new Employee();
        //cf.Customers.Add(c);
        //cf.Products.Add(p);
        //cf.ProductCats.Add(pc); 
        //cf.Employess.Add(em);
        //string json = JsonSerializer.Serialize(cf);
        //File.WriteAllText(FILE_NAME, json);
    }





    private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
        LoadData(true);
        

    }
    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
        SaveData();
        MessageBox.Show("File Written");
    }
    private void listToolStripMenuItem_Click(object sender, EventArgs e) {
        LoadData(false);
        CustomerForm customerForm = new CustomerForm();
        customerForm.CoffeeShop = _coffeeshop;
        customerForm.ShowDialog();
    }
    private void productCategoryListToolStripMenuItem_Click(object sender, EventArgs e) {
        LoadData(false);
        var productCategoryForm = new ProductCategoryForm(FILE_NAME) {
            CoffeeShop = _coffeeshop
        };
        productCategoryForm.Show();
    }
   


    //private void listToolStripMenuItem_Click(object sender, EventArgs e) {

    //    LoadData(false);
    //    CustomerForm customerForm = new CustomerForm();
    //    customerForm.CoffeeShop = _coffeeshop;
    //    customerForm.ShowDialog();
    //}

    private void dayCustomerCountToolStripMenuItem_Click(object sender, EventArgs e) {
        MessageBox.Show($"Today's Customers: {_coffeeshop.CustomersToday}");
    }

    private void newDayToolStripMenuItem_Click(object sender, EventArgs e) {
        _coffeeshop.CustomersToday = 0;
        if(_coffeeshop.Customers.Count == 1) {
            _coffeeshop.Customers.Remove(_coffeeshop.Customers.Last());
        }

        SaveData();
        MessageBox.Show("New day.!!");
    }


    private void CoffeeShopInitialize() {
        CoffeeShop cf = new CoffeeShop();
        _coffeeshop = cf;
    }


    public void LoadData(bool m ) {

        try {
           string json = File.ReadAllText(FILE_NAME);
           _coffeeshop = JsonSerializer.Deserialize<CoffeeShop>(json);
            if (m == true) {
                MessageBox.Show("Load Succefull");
            }
                
            
        }
        catch (Exception) {
            MessageBox.Show("File Not Found, New File Created");
            CoffeeShopInitialize();
            //throw;
        }

        saveToolStripMenuItem.Enabled = true;
        coffeeShopStatusToolStripMenuItem.Enabled = true;
        newDayToolStripMenuItem.Enabled = true;
        todaysCustomerToolStripMenuItem.Enabled = true;

    }

    public void SaveData() {
        string json = JsonSerializer.Serialize(_coffeeshop);
        File.WriteAllText(FILE_NAME, json);
    }


    private void coffeeShopStatusToolStripMenuItem_Click(object sender, EventArgs e) {
        MessageBox.Show(this, $"Managers: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Magager)}, " +
            $"Cashiers: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Cashier)}, " +
            $"Baristas: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Barista)}, " +
            $"Waiters: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Waiter)}, " +
            $"Product Categories: {_coffeeshop.ProductCats.Count} "+
            $"Products: {_coffeeshop.Products.Count} "+
            $"Active Customer: {_coffeeshop.Customers.Count} " +
            $"Customers today: {_coffeeshop.CustomersToday}");
    }
}
