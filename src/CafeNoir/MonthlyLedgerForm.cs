using CafeNoir.Core;

namespace CafeNoir {
    public partial class MonthlyLedgerForm : Form {
        private decimal _mExpenses = 0m;
        private decimal _mIncome = 0m;
        private decimal _mTotal = 0m;
        private decimal _mFixedExpenses = 0m;

        public CoffeeShop CoffeeShop { get; set; }
        public MonthlyLedgerForm(CoffeeShop _coffeeShop) {
            CoffeeShop = _coffeeShop;
            InitializeComponent();
        }
        private void MonthlyLedgerForm_Load(object sender, EventArgs e) {

            ControlExtensions.PopulateLedgerMonths(lookUpEditMonths.Properties);
            UpdateFields();
        }
        #region UI
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void lookUpEditMonths_EditValueChanged(object sender, EventArgs e) {
            UpdateMonthlyLedger();
        }
        private void spinEditYear_EditValueChanged(object sender, EventArgs e) {
            UpdateMonthlyLedger();
        }
        #endregion

        #region Methods
        private void UpdateMonthlyLedger() {
            SetUpTransactionGrid();

            grvTransactions.RefreshData();

            UpdateFields();
        }
        private void SetUpTransactionGrid() {
            int year = Convert.ToInt32(spinEditYear.EditValue);
            int month = Convert.ToInt32(lookUpEditMonths.EditValue);

            var transactionsConfirmed = GetLedgerOfSelectedMonth(year, month);
            bsTransactions.DataSource = transactionsConfirmed;
            grdTransactions.DataSource = bsTransactions;
        }
        private void UpdateFields() {
            _mFixedExpenses = CoffeeShop.RentingCost;
            _mTotal = _mIncome - _mExpenses - _mFixedExpenses;
            labelIncome.Text = "Income: +" + _mIncome.ToString() + " €";
            labelExpenses.Text = "Expenses: -" + _mExpenses.ToString() + " €";
            labelFixedExpenses.Text = "Fixed expenses: -" + _mFixedExpenses + " €";
            labelTotal.Text = "Profit: = " + _mTotal.ToString() + " €";
        }
        private List<Transaction> GetLedgerOfSelectedMonth(int year, int month) {
            var list = CoffeeShop.Transactions;
            List<Transaction> transactionsConfirmed = new List<Transaction>();
            ResetFieldValues();

            foreach (Transaction item in list) {
                if (item.Date.Year == year && item.Date.Month == month) {
                    _mIncome += item.TotalPrice;
                    _mExpenses += item.TotalCost;
                    transactionsConfirmed.Add(item);

                }
            }
            return list;
        }
        private void ResetFieldValues() {
            _mIncome = 0;
            _mExpenses = 0;
            _mFixedExpenses = 0;
            _mTotal = 0;
        }
        #endregion


    }
}
