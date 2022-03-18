using CafeNoir.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeNoir {
    public partial class TransactionForm : Form {
        public CoffeeShop CoffeeShop { get; }
        public TransactionForm(CoffeeShop coffeeShop) {
            CoffeeShop = coffeeShop;
            InitializeComponent();
        }
        
        private void TransactionForm_Load(object sender, EventArgs e) {
            var cashier = new Employee() {
                Name = "takis",
                EmployeeType = EmployeeType.Cashier
            };
            var emp = new Employee() {
                Name = "Gianna",
                EmployeeType = EmployeeType.Magager
            };
            CoffeeShop.Employess.Add(cashier);
            CoffeeShop.Employess.Add(emp);

            SetUpBindings();

        }

        #region UI
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnNew_Click(object sender, EventArgs e) {
            var employee = bsEmployees.Current as Employee;
            if(employee.EmployeeType != EmployeeType.Cashier) {
                MessageBox.Show("You have to pick a cashier!");
                return;
            }
            if(CoffeeShop.Customers.Count < 1) {
                MessageBox.Show("We don't have a customer!");
                return;
            }
            CoffeeShop.Products.Add(new Product() {
                Code = "000001",
                Cost = 5,
                Price = 15,
                Description = " Glikos Freddo",
                ProductCategoryID = new Guid()

            }) ;
            CoffeeShop.Products.Add(new Product() {
                Code = "000002",
                Cost = 5,
                Price = 15,
                Description = " Metrios Freddo",
                ProductCategoryID = new Guid()

            });

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
