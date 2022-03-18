using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeNoir.Core;

namespace CafeNoir {
    public partial class TransactionDetailsForm : Form {
        public CoffeeShop CoffeeShop { get; }
        public Transaction NewTransaction { get; set; }
        public Employee Employee { get; }
        public TransactionHandler THandler { get; set; } = new TransactionHandler();
        public TransactionDetailsForm(CoffeeShop coffeeShop, Employee employee) {
            InitializeComponent();
            CoffeeShop = coffeeShop;
            Employee = employee;
            NewTransaction = new Transaction() {
                CustomerID = coffeeShop.Customers[0].ID,
                EmployeeID = employee.ID,
                Date = DateTime.Now
            };
            labelCustomer.Text = CoffeeShop.Customers[0].Code;
        }
        private void TransactionDetailsForm_Load(object sender, EventArgs e) {
            UpdateLabelTotalPrice();
            SetUpBindings();
        }

        private void SetUpBindings() {
            bsProducts.DataSource = CoffeeShop.Products;
            gridProducts.DataSource = bsProducts;

            bsTransactionLines.DataSource = NewTransaction.TransactionLines;
            gridTransactionLines.DataSource = bsTransactionLines;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var selectedProduct = bsProducts.Current as Product;
            var newTransactionLine = new TransactionLine() {
                ProductID = selectedProduct.ID,
                TransactionID = NewTransaction.ID,
                Quantity = Convert.ToInt32(spinEditQuantity.Text),
                Price = selectedProduct.Price,
                TotalPrice = Convert.ToInt32(spinEditQuantity.Text) * selectedProduct.Price
            };

            THandler.AddTransLine(NewTransaction, newTransactionLine);         
            THandler.CalcTotalCosts(newTransactionLine, selectedProduct.Cost);

            THandler.UpdateTotalCost(NewTransaction);
            THandler.UpdateTotalPrice(NewTransaction);
            UpdateLabelTotalPrice();
            grvTransactionLines.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (NewTransaction.TransactionLines.Count == 0) {
                MessageBox.Show("No items added!");
                return;
            }
            CoffeeShop.Transactions.Add(NewTransaction);
            CoffeeShop.SaveChanges();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            var selectedLine = bsTransactionLines.Current as TransactionLine;
            if (selectedLine != null) {
                
                NewTransaction.TransactionLines.Remove(selectedLine);
                THandler.UpdateTotalCost(NewTransaction);
                THandler.UpdateTotalPrice(NewTransaction);
                UpdateLabelTotalPrice();
                grvTransactionLines.RefreshData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void UpdateLabelTotalPrice() {
            labelTotalPrice.Text = "Total: " + NewTransaction.TotalPrice.ToString();
        }
    }
}
