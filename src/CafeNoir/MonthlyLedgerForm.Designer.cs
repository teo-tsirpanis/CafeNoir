namespace CafeNoir {
    partial class MonthlyLedgerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonShow = new DevExpress.XtraEditors.SimpleButton();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelExpenses = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEditYear = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMonth = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Month = new DevExpress.XtraLayout.LayoutControlItem();
            this.Year = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditMonths = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpEditMonths);
            this.layoutControl1.Controls.Add(this.simpleButtonShow);
            this.layoutControl1.Controls.Add(this.labelProfit);
            this.layoutControl1.Controls.Add(this.labelExpenses);
            this.layoutControl1.Controls.Add(this.labelIncome);
            this.layoutControl1.Controls.Add(this.grdTransactions);
            this.layoutControl1.Controls.Add(this.spinEditYear);
            this.layoutControl1.Controls.Add(this.spinEditMonth);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonShow
            // 
            this.simpleButtonShow.Location = new System.Drawing.Point(12, 60);
            this.simpleButtonShow.Name = "simpleButtonShow";
            this.simpleButtonShow.Size = new System.Drawing.Size(776, 22);
            this.simpleButtonShow.StyleController = this.layoutControl1;
            this.simpleButtonShow.TabIndex = 11;
            this.simpleButtonShow.Text = "Show";
            this.simpleButtonShow.Click += new System.EventHandler(this.simpleButtonShow_Click);
            // 
            // labelProfit
            // 
            this.labelProfit.Location = new System.Drawing.Point(12, 418);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(776, 20);
            this.labelProfit.TabIndex = 10;
            this.labelProfit.Text = "Profit";
            // 
            // labelExpenses
            // 
            this.labelExpenses.Location = new System.Drawing.Point(12, 394);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(776, 20);
            this.labelExpenses.TabIndex = 9;
            this.labelExpenses.Text = "Expenses";
            // 
            // labelIncome
            // 
            this.labelIncome.Location = new System.Drawing.Point(12, 370);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(776, 20);
            this.labelIncome.TabIndex = 8;
            this.labelIncome.Text = "Income";
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(12, 86);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(776, 280);
            this.grdTransactions.TabIndex = 6;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colEmployeeID,
            this.colTotalPrice,
            this.colTotalCost});
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.OptionsBehavior.Editable = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 1;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Price";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            // 
            // colTotalCost
            // 
            this.colTotalCost.Caption = "Total Cost";
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 3;
            // 
            // spinEditYear
            // 
            this.spinEditYear.EditValue = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.spinEditYear.Location = new System.Drawing.Point(117, 36);
            this.spinEditYear.Name = "spinEditYear";
            this.spinEditYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditYear.Properties.MaxValue = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.spinEditYear.Properties.MinValue = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.spinEditYear.Properties.NullText = "Year";
            this.spinEditYear.Size = new System.Drawing.Size(671, 20);
            this.spinEditYear.StyleController = this.layoutControl1;
            this.spinEditYear.TabIndex = 5;
            // 
            // spinEditMonth
            // 
            this.spinEditMonth.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonth.Location = new System.Drawing.Point(117, 12);
            this.spinEditMonth.Name = "spinEditMonth";
            this.spinEditMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditMonth.Properties.IsFloatValue = false;
            this.spinEditMonth.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditMonth.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinEditMonth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonth.Properties.NullText = "Month";
            this.spinEditMonth.Size = new System.Drawing.Size(281, 20);
            this.spinEditMonth.StyleController = this.layoutControl1;
            this.spinEditMonth.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Month,
            this.Year,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // Month
            // 
            this.Month.Control = this.spinEditMonth;
            this.Month.Location = new System.Drawing.Point(0, 0);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(390, 24);
            this.Month.TextSize = new System.Drawing.Size(93, 13);
            // 
            // Year
            // 
            this.Year.Control = this.spinEditYear;
            this.Year.Location = new System.Drawing.Point(0, 24);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(780, 24);
            this.Year.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTransactions;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 284);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelIncome;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 358);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelExpenses;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 382);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelProfit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 406);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonShow;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lookUpEditMonths
            // 
            this.lookUpEditMonths.Location = new System.Drawing.Point(507, 12);
            this.lookUpEditMonths.Name = "lookUpEditMonths";
            this.lookUpEditMonths.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMonths.Size = new System.Drawing.Size(281, 20);
            this.lookUpEditMonths.StyleController = this.layoutControl1;
            this.lookUpEditMonths.TabIndex = 1;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lookUpEditMonths;
            this.layoutControlItem6.Location = new System.Drawing.Point(390, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(390, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 13);
            // 
            // MonthlyLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MonthlyLedgerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonthlyLedgerForm";
            this.Load += new System.EventHandler(this.MonthlyLedgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit spinEditYear;
        private DevExpress.XtraEditors.SpinEdit spinEditMonth;
        private DevExpress.XtraLayout.LayoutControlItem Month;
        private DevExpress.XtraLayout.LayoutControlItem Year;
        private Label labelExpenses;
        private Label labelIncome;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Label labelProfit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonShow;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BindingSource bsTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMonths;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}