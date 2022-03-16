using CafeNoir.Core;
using System.IO;
using System.Text.Json;

namespace CafeNoir;

public partial class CoffeeShopForm : Form
{
    private const string FILE_NAME = "coffeeshop.json";
    private CoffeeShop _coffeeshop;


    public CoffeeShopForm()
    {
        InitializeComponent();
    }

    private void CoffeeShopForm_Load(object sender, EventArgs e) {
        
        saveToolStripMenuItem.Enabled = false;


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
        LoadData();
        MessageBox.Show(this, "Load");
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
        SaveData();
        MessageBox.Show("Saved");
    }



    public void LoadData() {

        string json = File.ReadAllText(FILE_NAME);
        _coffeeshop = JsonSerializer.Deserialize<CoffeeShop>(json);
        saveToolStripMenuItem.Enabled = true;


    }


    public void SaveData() {
        string json = JsonSerializer.Serialize(_coffeeshop);
        File.WriteAllText(FILE_NAME, json);
    }

    private void listToolStripMenuItem_Click(object sender, EventArgs e) {
        LoadData();
        CustomerForm customerForm = new CustomerForm();
        customerForm.CoffeeShop = _coffeeshop;
        customerForm.ShowDialog();
    }
}
