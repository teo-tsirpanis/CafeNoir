
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
            if (employee.EmployeeType != EmployeeType.Cashier) {
                MessageBox.Show("You have to pick a cashier!");
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

            bsEmployees.DataSource = CoffeeShop.Employess;
            gridEmployees.DataSource = bsEmployees;
        }
        #endregion
    }
}
