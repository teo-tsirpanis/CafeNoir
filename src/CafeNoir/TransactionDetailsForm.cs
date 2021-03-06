using CafeNoir.Core;

namespace CafeNoir {
    public partial class TransactionDetailsForm : Form {

        private string _defaultQuantity = "1";
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
                Date = DateTime.Now,
                EmployeeName = employee.Name
                
            };

        }
        private void TransactionDetailsForm_Load(object sender, EventArgs e) {
            UpdateLabelTotalPrice();
            labelCustomer.Text = "Customer: " + CoffeeShop.Customers[0].Code;
            ControlExtensions.PopulatePaymentMethod(lookUpPaymentMethod.Properties);
            SetUpBindings();
        }
        #region UI
        private void btnAdd_Click(object sender, EventArgs e) {
            var selectedProduct = bsProducts.Current as Product;
            if (selectedProduct != null) {
                AddNewLine(selectedProduct);
                ResetQuantity();
            }



        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e) {
            string errorMessage = THandler.FinalizeTransaction(NewTransaction);
            if (errorMessage != string.Empty) {
                MessageBox.Show(errorMessage);
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
                UpdateTransaction();
                UpdateLabelTotalPrice();
                grvTransactionLines.RefreshData();
            }
        }
        #endregion

        #region Methods
        private void SetUpBindings() {
            bsProducts.DataSource = CoffeeShop.Products;
            gridProducts.DataSource = bsProducts;

            bsTransactionLines.DataSource = NewTransaction.TransactionLines;
            gridTransactionLines.DataSource = bsTransactionLines;

            bsTransactions.DataSource = NewTransaction;
            lookUpPaymentMethod.DataBindings.Add(new Binding("EditValue", bsTransactions, "PaymentMethod", true));
        }
        private void AddNewLine(Product selectedProduct) {
            var newTransactionLine = new TransactionLine() {
                ProductID = selectedProduct.ID,
                TransactionID = NewTransaction.ID,
                Quantity = Convert.ToInt32(spinEditQuantity.Text),
                Price = selectedProduct.Price,
                TotalPrice = Convert.ToInt32(spinEditQuantity.Text) * selectedProduct.Price,
                DisplayPrice = Convert.ToInt32(spinEditQuantity.Text) * selectedProduct.Price,
                ProductDes = selectedProduct.Description
            };

            THandler.AddTransLine(NewTransaction, newTransactionLine);
            THandler.CalcTotalCosts(newTransactionLine, selectedProduct.Cost);

            UpdateTransaction();
            UpdateLabelTotalPrice();
            grvTransactionLines.RefreshData();
        }
        private void UpdateLabelTotalPrice() {
            labelTotalPrice.Text = "Total: " + NewTransaction.TotalPrice.ToString();
        }
        private void UpdateTransaction() {
            THandler.UpdateTotalCost(NewTransaction);
            THandler.UpdateTotalPrice(NewTransaction);
        }
        private void ResetQuantity() {
            spinEditQuantity.Text = _defaultQuantity;
        }


        #endregion
    }

}
