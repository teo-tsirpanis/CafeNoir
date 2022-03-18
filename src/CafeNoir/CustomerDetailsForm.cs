using CafeNoir.Core;

namespace CafeNoir
{
    public partial class CustomerDetailsForm : Form
    {
        public CoffeeShop CoffeeShop { get; }
        public Customer Customer { get; }

        public CustomerDetailsForm(CoffeeShop coffeeShop, Customer? customer)
        {
            CoffeeShop = coffeeShop;

            if (customer == null)
            {
                customer = new Customer($"{CoffeeShop.Customers.Count:D3}");
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
            CoffeeShop.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
