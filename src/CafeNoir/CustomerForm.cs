using CafeNoir.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeNoir {
    public partial class CustomerForm : Form {

        public CoffeeShop CoffeeShop { get; set; }
        private const string FILE_NAME = "coffeeshop.json";


        public CustomerForm() {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e) {

            bsCoffeeShop.DataSource = CoffeeShop;

            bsCustomers.DataSource = bsCoffeeShop;
            bsCustomers.DataMember = "Customers";
            gridControlCustomers.DataSource = bsCustomers;
        }

        private void btnNew_Click(object sender, EventArgs e) {

            if (CoffeeShop.Customers.Count >= 1) {
                MessageBox.Show(this, "There is an active customer.!");
                return;
            }
            //Customer customer = new Customer("001");
            CustomerDetailsForm cdf = new CustomerDetailsForm();
            //cdf.Customer=customer;
            cdf.CoffeeShop = bsCoffeeShop.Current as CoffeeShop;
            cdf.ShowDialog();
            gridView1.RefreshData();

        }

        private void btnDelete_Click(object sender, EventArgs e) {

            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Customer", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            var customer = bsCustomers.Current as Customer;
            bsCustomers.Remove(customer);
            SaveData();
            

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void SaveData() {
            var coffeeshop = bsCoffeeShop.Current as CoffeeShop;
            string json = JsonSerializer.Serialize(coffeeshop);
            File.WriteAllText(FILE_NAME, json);
        }

        private void btnEdit_Click(object sender, EventArgs e) {

            CustomerDetailsForm cdf = new CustomerDetailsForm();
            cdf.Customer = bsCustomers.Current as Customer;
            cdf.CoffeeShop = bsCoffeeShop.Current as CoffeeShop;
            cdf.ShowDialog();
            gridView1.RefreshData();

        }
    }
}
