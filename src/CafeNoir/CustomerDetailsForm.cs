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
    public partial class CustomerDetailsForm : Form {


        private const string FILE_NAME = "coffeeshop.json";
        public CoffeeShop CoffeeShop { get; set; }
        public Customer Customer { get; set; }

        public CustomerDetailsForm() {
            InitializeComponent();
        }



        private void CustomerDetailsForm_Load(object sender, EventArgs e) {

            if (Customer == null) {
                Customer = new Customer("005");
                CoffeeShop.Customers.Add(Customer);
            }

            bsCustomer.DataSource = Customer;
            textEditCode.DataBindings.Add("EditValue", bsCustomer,"Code");
            textEditDescription.DataBindings.Add("EditValue", bsCustomer,"Description");      

        }

        private void btnSave_Click(object sender, EventArgs e) {
            //CoffeeShop.Customers.Add(Customer);
            string json = JsonSerializer.Serialize(CoffeeShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
