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
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeShopStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.todaysCustomerToolStripMenuItem,
            this.newDayToolStripMenuItem,
            this.coffeeShopStatusToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // todaysCustomerToolStripMenuItem
            // 
            this.todaysCustomerToolStripMenuItem.Name = "todaysCustomerToolStripMenuItem";
            this.todaysCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todaysCustomerToolStripMenuItem.Text = "Today\'s Customers";
            this.todaysCustomerToolStripMenuItem.Click += new System.EventHandler(this.dayCustomerCountToolStripMenuItem_Click);
            // 
            // newDayToolStripMenuItem
            // 
            this.newDayToolStripMenuItem.Name = "newDayToolStripMenuItem";
            this.newDayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newDayToolStripMenuItem.Text = "New Day";
            this.newDayToolStripMenuItem.Click += new System.EventHandler(this.newDayToolStripMenuItem_Click);
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
            // CoffeeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoffeeShopForm";
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
    private ToolStripMenuItem loadToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem customersToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuItem;
    private ToolStripMenuItem todaysCustomerToolStripMenuItem;
    private ToolStripMenuItem newDayToolStripMenuItem;
    private ToolStripMenuItem coffeeShopStatusToolStripMenuItem;
}
