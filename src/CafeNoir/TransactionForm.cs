
using CafeNoir.Core;

namespace CafeNoir {
    public partial class TransactionForm : Form {
        public CoffeeShop CoffeeShop { get; }
        public TransactionForm(CoffeeShop coffeeShop) {
            CoffeeShop = coffeeShop;
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            SetUpBindings();
        }

        #region UI
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnNew_Click(object sender, EventArgs e) {
            var employee = bsEmployees.Current as Employee;
            if (employee == null) {
                MessageBox.Show("We need an employee");
                return;
            }
            if (employee.EmployeeType != EmployeeType.Cashier && employee.EmployeeType != EmployeeType.Manager) {
                MessageBox.Show("Only a manager or a cashier can create a new transaction!");
                return;
            }
            if (CoffeeShop.Customers.Count < 1) {
                MessageBox.Show("We don't have a customer!");
                return;
            }

            var transactionDetailForm = new TransactionDetailsForm(CoffeeShop, employee);
            transactionDetailForm.ShowDialog();
            grvTransactions.RefreshData();

        }
        #endregion

        #region Methods
        private void SetUpBindings() {
            bsTransactions.DataSource = CoffeeShop.Transactions;
            gridTransactions.DataSource = bsTransactions;

            bsEmployees.DataSource = CoffeeShop.Employees;
            gridEmployees.DataSource = bsEmployees;
        }
        #endregion
    }
}
