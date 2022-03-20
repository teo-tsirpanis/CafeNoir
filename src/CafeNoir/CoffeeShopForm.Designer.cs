namespace CafeNoir;

partial class CoffeeShopForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeShopStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.productToolStripMenuItem,
            this.productCategoriesToolStripMenuItem,

            this.productToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.coffeeShopStatusToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // coffeeShopStatusToolStripMenuItem
            // 
            this.coffeeShopStatusToolStripMenuItem.Name = "coffeeShopStatusToolStripMenuItem";
            this.coffeeShopStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coffeeShopStatusToolStripMenuItem.Text = "CoffeeShop Status";
            this.coffeeShopStatusToolStripMenuItem.Click += new System.EventHandler(this.coffeeShopStatusToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // productCategoriesToolStripMenuItem
            // 
            this.productCategoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productCategoryListToolStripMenuItem});
            this.productCategoriesToolStripMenuItem.Name = "productCategoriesToolStripMenuItem";
            this.productCategoriesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.productCategoriesToolStripMenuItem.Text = "Product Categories";
            // 
            // productCategoryListToolStripMenuItem
            // 
            this.productCategoryListToolStripMenuItem.Name = "productCategoryListToolStripMenuItem";
            this.productCategoryListToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.productCategoryListToolStripMenuItem.Text = "List";
            this.productCategoryListToolStripMenuItem.Click += new System.EventHandler(this.productCategoryListToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuProduct});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // listToolStripMenuProduct
            // 
            this.listToolStripMenuProduct.Name = "listToolStripMenuProduct";
            this.listToolStripMenuProduct.Size = new System.Drawing.Size(92, 22);
            this.listToolStripMenuProduct.Text = "List";
            this.listToolStripMenuProduct.Click += new System.EventHandler(this.listToolStripMenuItem2_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuEmployees});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // listToolStripMenuEmployees
            // 
            this.listToolStripMenuEmployees.Name = "listToolStripMenuEmployees";
            this.listToolStripMenuEmployees.Size = new System.Drawing.Size(92, 22);
            this.listToolStripMenuEmployees.Text = "List";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuTransaction});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // listToolStripMenuTransaction
            // 
            this.listToolStripMenuTransaction.Name = "listToolStripMenuTransaction";
            this.listToolStripMenuTransaction.Size = new System.Drawing.Size(92, 22);
            this.listToolStripMenuTransaction.Text = "List";
            this.listToolStripMenuTransaction.Click += new System.EventHandler(this.listToolStripMenuItem1_Click_1);
            // 
            // monthlyLedgerToolStripMenuItem
            // 
            this.monthlyLedgerToolStripMenuItem.Name = "monthlyLedgerToolStripMenuItem";
            this.monthlyLedgerToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.monthlyLedgerToolStripMenuItem.Text = "Monthly Ledger";
            this.monthlyLedgerToolStripMenuItem.Click += new System.EventHandler(this.monthlyLedgerToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listEmployeesToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // listEmployeesToolStripMenuItem
            // 
            this.listEmployeesToolStripMenuItem.Name = "listEmployeesToolStripMenuItem";
            this.listEmployeesToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.listEmployeesToolStripMenuItem.Text = "List";
            this.listEmployeesToolStripMenuItem.Click += new System.EventHandler(this.listEmployeesToolStripMenuItem_Click);
            // 
            // CoffeeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoffeeShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee-Shop";
            this.Load += new System.EventHandler(this.CoffeeShopForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem reloadToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem customersToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuItem;
    private ToolStripMenuItem productCategoriesToolStripMenuItem;
    private ToolStripMenuItem productCategoryListToolStripMenuItem;
    private ToolStripMenuItem coffeeShopStatusToolStripMenuItem;
    private ToolStripMenuItem employeesToolStripMenuItem;
    private ToolStripMenuItem listEmployeesToolStripMenuItem;
    private ToolStripMenuItem transactionsToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuItem1;
    private ToolStripMenuItem productToolStripMenuItem;
    private ToolStripMenuItem productListToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuProduct;
    private ToolStripMenuItem listToolStripMenuEmployees;
    private ToolStripMenuItem transactionToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuTransaction;
    private ToolStripMenuItem monthlyLedgerToolStripMenuItem;
}
