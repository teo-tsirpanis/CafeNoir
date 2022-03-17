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
        LoadData();
        saveToolStripMenuItem.Enabled = false;
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
        LoadData();
        MessageBox.Show(this, $"Managers: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Magager)}, " +
            $"Cashiers: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Cashier)}, " +
            $"Baristas: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Barista)}, " +
            $"Waiters: {_coffeeshop.Employess.Count(x => x.EmployeeType == EmployeeType.Waiter)}, " +
            $"Customers: {_coffeeshop.Customers.Count}");

    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
        SaveData();
        MessageBox.Show("Saved");
    }

    public void LoadData() {

        if (!File.Exists(FILE_NAME)) {
            using (File.Create(FILE_NAME)) ;
        }
        string json = File.ReadAllText(FILE_NAME);

        try {
            _coffeeshop = JsonSerializer.Deserialize<CoffeeShop>(json);
            saveToolStripMenuItem.Enabled = true;
        }
        catch (Exception) {
            _coffeeshop = new CoffeeShop();
            SaveData();
        }

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
