using CafeNoir.Core;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    public partial class MonthlyLedgerForm : Form {

        public CoffeeShop CoffeeShop { get; set; }
        public MonthlyLedgerForm(CoffeeShop _coffeeShop) {
            CoffeeShop = _coffeeShop;
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void simpleButtonShow_Click(object sender, EventArgs e) {
            int year = Convert.ToInt32(spinEditYear.EditValue);
            int month = Convert.ToInt32(lookUpEditMonths.EditValue);


            decimal expenses = 0;
            decimal income = 0;
            decimal profit = 0; 


            var list = CoffeeShop.Transactions;
            List<Transaction> transactionsConfirmed = new List<Transaction>();


            foreach (Transaction item in list) {
                if(item.Date.Year == year && item.Date.Month == month) {
                    income += item.TotalPrice;
                    expenses += item.TotalCost;
                    transactionsConfirmed.Add(item);

                }
            }
            bsTransactions.DataSource = transactionsConfirmed;
            grdTransactions.DataSource = bsTransactions;
            grvTransactions.RefreshData();


            profit = income - expenses - 3000;

            labelExpenses.Text = "Expenses: "+expenses.ToString()+ " €";
            labelIncome.Text = "Income: "+income.ToString() + " €";
            labelFixedExpenses.Text = "Profit: "+profit.ToString() + " €";

        }



        private void MonthlyLedgerForm_Load(object sender, EventArgs e) {

           ControlExtensions.PopulateLedgerMonths(lookUpEditMonths.Properties);
        }
    }
}
