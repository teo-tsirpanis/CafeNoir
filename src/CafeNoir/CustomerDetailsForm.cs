using CafeNoir.Core;
using System.IO;
using System.Text.Json;

namespace CafeNoir
{
    public partial class CustomerDetailsForm : Form
    {
        private const string FILE_NAME = "coffeeshop.json";
        public CoffeeShop CoffeeShop { get; }
        public Customer Customer { get; }

        public CustomerDetailsForm(CoffeeShop coffeeShop, Customer? customer)
        {
            CoffeeShop = coffeeShop;

            if (customer == null)
            {
                customer = new Customer($"{CoffeeShop.Customers.Count:03}");
                CoffeeShop.Customers.Add(customer);
            }

            Customer = customer;

            InitializeComponent();
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            bsCustomer.DataSource = Customer;
            textEditCode.DataBindings.Add("EditValue", bsCustomer, "Code");
            textEditDescription.DataBindings.Add("EditValue", bsCustomer, "Description");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //CoffeeShop.Customers.Add(Customer);
            string json = JsonSerializer.Serialize(CoffeeShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
