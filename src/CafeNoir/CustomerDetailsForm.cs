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
        public Customer _oldCustomer;

        public CustomerDetailsForm(CoffeeShop coffeeShop, Customer? customer)
        {
            CoffeeShop = coffeeShop;

            if (customer == null)
            {
                Customer = new Customer("0001");
                CoffeeShop.Customers.Add(Customer);
            }
            else {
                Customer = customer;    
                _oldCustomer = customer.ShallowCopy();
            }

           

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
            ////CoffeeShop.Customers.Add(Customer);
            //string json = JsonSerializer.Serialize(CoffeeShop);
            //File.WriteAllText(FILE_NAME, json);
            //DialogResult = DialogResult.OK;
            CoffeeShop.SaveChanges();
            Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (_oldCustomer != null) {
                CoffeeShop.Customers[0] = _oldCustomer;
            }
            else {
                CoffeeShop.Customers.Remove(Customer);
            }
            Close();
        }
    }
}
