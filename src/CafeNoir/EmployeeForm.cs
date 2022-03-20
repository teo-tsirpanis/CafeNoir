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
            bsEmployees.DataMember = nameof(_coffeeShop.Employees);
            gridControlEmployees.DataSource = bsEmployees;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeDropDown_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var employeeType = (EmployeeType)e.Item.Tag;

            var employee = new Employee() { EmployeeType = employeeType };
            try
            {
                _coffeeShop.Employees.Add(employee);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var edf = new EmployeeDetailsForm(_coffeeShop, employee, false);
            edf.ShowDialog();
            gridView1.RefreshData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes)
                return;

            var customer = bsEmployees.Current as Employee;
            try
            {
                bsEmployees.Remove(customer);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _coffeeShop.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var cdf = new EmployeeDetailsForm(_coffeeShop, (Employee)bsEmployees.Current, true);
            cdf.ShowDialog();
            gridView1.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _coffeeShop.SaveChanges();
            DialogResult = DialogResult.OK;
        }


    }
}
