using CafeNoir.Core;

namespace CafeNoir
{
    public partial class CustomerForm : Form
    {
        public CoffeeShop CoffeeShop { get; }

        public CustomerForm(CoffeeShop coffeeShop)
        {
            CoffeeShop = coffeeShop;
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            bsCoffeeShop.DataSource = CoffeeShop;

            bsCustomers.DataSource = bsCoffeeShop;
            bsCustomers.DataMember = "Customers";
            gridControlCustomers.DataSource = bsCustomers;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (CoffeeShop.Customers.Count >= 1)
            {
                MessageBox.Show(this, "There is an active customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cdf = new CustomerDetailsForm(CoffeeShop, null);
            cdf.ShowDialog();
            gridView1.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Customer?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes)
                return;

            var customer = bsCustomers.Current as Customer;
            bsCustomers.Remove(customer);
            CoffeeShop.SaveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var cdf = new CustomerDetailsForm(CoffeeShop, (Customer)bsCustomers.Current);
            cdf.ShowDialog();
            gridView1.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoffeeShop.SaveChanges();
        }
    }
}
