using CafeNoir.Core;

namespace CafeNoir
{
    public partial class EmployeeForm : Form
    {
        private readonly CoffeeShop _coffeeShop;

        public EmployeeForm(CoffeeShop coffeeShop)
        {
            _coffeeShop = coffeeShop;
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            bsCoffeeShop.DataSource = _coffeeShop;

            bsEmployees.DataSource = bsCoffeeShop;
            bsEmployees.DataMember = nameof(_coffeeShop.Employess);
            gridControlEmployees.DataSource = bsEmployees;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _coffeeShop.SaveChanges();
        }
    }
}
