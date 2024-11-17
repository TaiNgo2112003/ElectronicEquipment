namespace CoffeChainManagement.Views
{
    partial class ShoppingCart
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
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet21 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet21();
            this.cartTableAdapter = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet21TableAdapters.CartTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cartIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRentDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet22 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet22();
            this.cartTableAdapter1 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet22TableAdapters.CartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.coffeChainManagementDBDataSet21;
            // 
            // coffeChainManagementDBDataSet21
            // 
            this.coffeChainManagementDBDataSet21.DataSetName = "CoffeChainManagementDBDataSet21";
            this.coffeChainManagementDBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartIDDataGridViewTextBoxColumn1,
            this.userIDDataGridViewTextBoxColumn1,
            this.productIDDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.isRentDataGridViewCheckBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1,
            this.discountCodeDataGridViewTextBoxColumn1,
            this.createdAtDataGridViewTextBoxColumn1,
            this.updatedAtDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.cartBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1436, 337);
            this.dataGridView2.TabIndex = 1;
            // 
            // cartIDDataGridViewTextBoxColumn1
            // 
            this.cartIDDataGridViewTextBoxColumn1.DataPropertyName = "CartID";
            this.cartIDDataGridViewTextBoxColumn1.HeaderText = "CartID";
            this.cartIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cartIDDataGridViewTextBoxColumn1.Name = "cartIDDataGridViewTextBoxColumn1";
            this.cartIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cartIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            this.userIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            this.productIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // isRentDataGridViewCheckBoxColumn1
            // 
            this.isRentDataGridViewCheckBoxColumn1.DataPropertyName = "IsRent";
            this.isRentDataGridViewCheckBoxColumn1.HeaderText = "IsRent";
            this.isRentDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.isRentDataGridViewCheckBoxColumn1.Name = "isRentDataGridViewCheckBoxColumn1";
            this.isRentDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            this.startDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            this.endDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // discountCodeDataGridViewTextBoxColumn1
            // 
            this.discountCodeDataGridViewTextBoxColumn1.DataPropertyName = "DiscountCode";
            this.discountCodeDataGridViewTextBoxColumn1.HeaderText = "DiscountCode";
            this.discountCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.discountCodeDataGridViewTextBoxColumn1.Name = "discountCodeDataGridViewTextBoxColumn1";
            this.discountCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn1
            // 
            this.createdAtDataGridViewTextBoxColumn1.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn1.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn1.Name = "createdAtDataGridViewTextBoxColumn1";
            this.createdAtDataGridViewTextBoxColumn1.Width = 125;
            // 
            // updatedAtDataGridViewTextBoxColumn1
            // 
            this.updatedAtDataGridViewTextBoxColumn1.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.updatedAtDataGridViewTextBoxColumn1.Name = "updatedAtDataGridViewTextBoxColumn1";
            this.updatedAtDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataMember = "Cart";
            this.cartBindingSource1.DataSource = this.coffeChainManagementDBDataSet22;
            // 
            // coffeChainManagementDBDataSet22
            // 
            this.coffeChainManagementDBDataSet22.DataSetName = "CoffeChainManagementDBDataSet22";
            this.coffeChainManagementDBDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 747);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Data.CoffeChainManagementDBDataSet21 coffeChainManagementDBDataSet21;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private Data.CoffeChainManagementDBDataSet21TableAdapters.CartTableAdapter cartTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Data.CoffeChainManagementDBDataSet22 coffeChainManagementDBDataSet22;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private Data.CoffeChainManagementDBDataSet22TableAdapters.CartTableAdapter cartTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRentDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn1;
    }
}