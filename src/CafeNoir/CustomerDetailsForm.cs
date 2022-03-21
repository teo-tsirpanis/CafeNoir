using CafeNoir.Core;

namespace CafeNoir
{
    public partial class CustomerDetailsForm : Form
    {
        public CoffeeShop CoffeeShop { get; }
        public Customer Customer { get; }
        public Customer _oldCustomer;

        public CustomerDetailsForm(CoffeeShop coffeeShop, Customer? customer)
        {
            CoffeeShop = coffeeShop;

            if (customer == null)
            {
                customer = new Customer($"{CoffeeShop.Customers.Count:D3}");
                Customer = customer;
                CoffeeShop.Customers.Add(customer);
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
            CoffeeShop.SaveChanges();
            DialogResult = DialogResult.OK;
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
