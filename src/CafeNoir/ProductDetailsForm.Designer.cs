namespace CafeNoir
{
    partial class ProductDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ctrlCost = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPrice = new DevExpress.XtraEditors.TextEdit();
            this.ctrlProductCategoryID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ctrlDescription = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductCategoryID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProductCategoryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ctrlCost);
            this.layoutControl1.Controls.Add(this.ctrlPrice);
            this.layoutControl1.Controls.Add(this.ctrlProductCategoryID);
            this.layoutControl1.Controls.Add(this.ctrlDescription);
            this.layoutControl1.Controls.Add(this.ctrlCode);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-822, 378, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(709, 632);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ctrlCost
            // 
            this.ctrlCost.Location = new System.Drawing.Point(87, 116);
            this.ctrlCost.Name = "ctrlCost";
            this.ctrlCost.Size = new System.Drawing.Size(393, 22);
            this.ctrlCost.StyleController = this.layoutControl1;
            this.ctrlCost.TabIndex = 10;
            // 
            // ctrlPrice
            // 
            this.ctrlPrice.Location = new System.Drawing.Point(87, 90);
            this.ctrlPrice.Name = "ctrlPrice";
            this.ctrlPrice.Size = new System.Drawing.Size(393, 22);
            this.ctrlPrice.StyleController = this.layoutControl1;
            this.ctrlPrice.TabIndex = 9;
            // 
            // ctrlProductCategoryID
            // 
            this.ctrlProductCategoryID.Location = new System.Drawing.Point(87, 64);
            this.ctrlProductCategoryID.Name = "ctrlProductCategoryID";
            this.ctrlProductCategoryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlProductCategoryID.Properties.PopupView = this.gridLookUpEdit1View;
            this.ctrlProductCategoryID.Size = new System.Drawing.Size(393, 22);
            this.ctrlProductCategoryID.StyleController = this.layoutControl1;
            this.ctrlProductCategoryID.TabIndex = 8;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Location = new System.Drawing.Point(87, 38);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(393, 22);
            this.ctrlDescription.StyleController = this.layoutControl1;
            this.ctrlDescription.TabIndex = 7;
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(87, 12);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(393, 22);
            this.ctrlCode.StyleController = this.layoutControl1;
            this.ctrlCode.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(341, 27);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 593);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(340, 27);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlCode,
            this.layoutControlDescription,
            this.layoutControlProductCategoryID,
            this.layoutControlPrice,
            this.layoutControlCost,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(709, 632);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 130);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(689, 451);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 581);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(344, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(344, 581);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(345, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlCode
            // 
            this.layoutControlCode.Control = this.ctrlCode;
            this.layoutControlCode.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCode.Name = "layoutControlCode";
            this.layoutControlCode.Size = new System.Drawing.Size(472, 26);
            this.layoutControlCode.Text = "Code";
            this.layoutControlCode.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlDescription
            // 
            this.layoutControlDescription.Control = this.ctrlDescription;
            this.layoutControlDescription.Location = new System.Drawing.Point(0, 26);
            this.layoutControlDescription.Name = "layoutControlDescription";
            this.layoutControlDescription.Size = new System.Drawing.Size(472, 26);
            this.layoutControlDescription.Text = "Description";
            this.layoutControlDescription.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlProductCategoryID
            // 
            this.layoutControlProductCategoryID.Control = this.ctrlProductCategoryID;
            this.layoutControlProductCategoryID.Location = new System.Drawing.Point(0, 52);
            this.layoutControlProductCategoryID.Name = "layoutControlProductCategoryID";
            this.layoutControlProductCategoryID.Size = new System.Drawing.Size(472, 26);
            this.layoutControlProductCategoryID.Text = "Product";
            this.layoutControlProductCategoryID.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlPrice
            // 
            this.layoutControlPrice.Control = this.ctrlPrice;
            this.layoutControlPrice.Location = new System.Drawing.Point(0, 78);
            this.layoutControlPrice.Name = "layoutControlPrice";
            this.layoutControlPrice.Size = new System.Drawing.Size(472, 26);
            this.layoutControlPrice.Text = "Price";
            this.layoutControlPrice.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlCost
            // 
            this.layoutControlCost.Control = this.ctrlCost;
            this.layoutControlCost.Location = new System.Drawing.Point(0, 104);
            this.layoutControlCost.Name = "layoutControlCost";
            this.layoutControlCost.Size = new System.Drawing.Size(472, 26);
            this.layoutControlCost.Text = "Cost";
            this.layoutControlCost.TextSize = new System.Drawing.Size(63, 16);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(472, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(217, 130);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bsProduct
            // 
            this.bsProduct.DataSource = typeof(CafeNoir.Core.Product);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(390, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem2";
            this.emptySpaceItem3.Size = new System.Drawing.Size(390, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 632);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProductCategoryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCode;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit ctrlDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDescription;
        private DevExpress.XtraEditors.TextEdit ctrlCost;
        private DevExpress.XtraEditors.TextEdit ctrlPrice;
        private DevExpress.XtraEditors.GridLookUpEdit ctrlProductCategoryID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductCategoryID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCost;
        private BindingSource bsProduct;
    }
}