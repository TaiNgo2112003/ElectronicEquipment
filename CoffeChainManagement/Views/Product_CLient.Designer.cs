namespace CoffeChainManagement.Views
{
    partial class Product_CLient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet14BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet14 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet14();
            this.coffeChainManagementDBDataSet15 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet15();
            this.coffeChainManagementDBDataSet15BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet15TableAdapters.CategoryTableAdapter();
            this.productTableAdapter = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet14TableAdapters.ProductTableAdapter();
            this.cbRentProduct = new System.Windows.Forms.CheckBox();
            this.cbBuyProduct = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantityProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPromotionCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet14BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet15BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.packageDataGridViewTextBoxColumn,
            this.isDiscontinuedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageDataGridViewTextBoxColumn
            // 
            this.packageDataGridViewTextBoxColumn.DataPropertyName = "Package";
            this.packageDataGridViewTextBoxColumn.HeaderText = "Package";
            this.packageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageDataGridViewTextBoxColumn.Name = "packageDataGridViewTextBoxColumn";
            this.packageDataGridViewTextBoxColumn.Width = 125;
            // 
            // isDiscontinuedDataGridViewCheckBoxColumn
            // 
            this.isDiscontinuedDataGridViewCheckBoxColumn.DataPropertyName = "IsDiscontinued";
            this.isDiscontinuedDataGridViewCheckBoxColumn.HeaderText = "IsDiscontinued";
            this.isDiscontinuedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isDiscontinuedDataGridViewCheckBoxColumn.Name = "isDiscontinuedDataGridViewCheckBoxColumn";
            this.isDiscontinuedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.coffeChainManagementDBDataSet14BindingSource;
            // 
            // coffeChainManagementDBDataSet14BindingSource
            // 
            this.coffeChainManagementDBDataSet14BindingSource.DataSource = this.coffeChainManagementDBDataSet14;
            this.coffeChainManagementDBDataSet14BindingSource.Position = 0;
            // 
            // coffeChainManagementDBDataSet14
            // 
            this.coffeChainManagementDBDataSet14.DataSetName = "CoffeChainManagementDBDataSet14";
            this.coffeChainManagementDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeChainManagementDBDataSet15
            // 
            this.coffeChainManagementDBDataSet15.DataSetName = "CoffeChainManagementDBDataSet15";
            this.coffeChainManagementDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeChainManagementDBDataSet15BindingSource
            // 
            this.coffeChainManagementDBDataSet15BindingSource.DataSource = this.coffeChainManagementDBDataSet15;
            this.coffeChainManagementDBDataSet15BindingSource.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.coffeChainManagementDBDataSet15BindingSource;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // cbRentProduct
            // 
            this.cbRentProduct.AutoSize = true;
            this.cbRentProduct.Location = new System.Drawing.Point(141, 386);
            this.cbRentProduct.Name = "cbRentProduct";
            this.cbRentProduct.Size = new System.Drawing.Size(122, 20);
            this.cbRentProduct.TabIndex = 1;
            this.cbRentProduct.Text = "Thuê sản phẩm";
            this.cbRentProduct.UseVisualStyleBackColor = true;
            this.cbRentProduct.CheckedChanged += new System.EventHandler(this.cbRentProduct_CheckedChanged);
            // 
            // cbBuyProduct
            // 
            this.cbBuyProduct.AutoSize = true;
            this.cbBuyProduct.Location = new System.Drawing.Point(705, 386);
            this.cbBuyProduct.Name = "cbBuyProduct";
            this.cbBuyProduct.Size = new System.Drawing.Size(117, 20);
            this.cbBuyProduct.TabIndex = 2;
            this.cbBuyProduct.Text = "Mua sản phẩm";
            this.cbBuyProduct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            this.label1.Visible = false;
            // 
            // dateBeginDate
            // 
            this.dateBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBeginDate.Location = new System.Drawing.Point(244, 435);
            this.dateBeginDate.Name = "dateBeginDate";
            this.dateBeginDate.Size = new System.Drawing.Size(343, 27);
            this.dateBeginDate.TabIndex = 4;
            this.dateBeginDate.Visible = false;
            // 
            // dateEndDate
            // 
            this.dateEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndDate.Location = new System.Drawing.Point(244, 497);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(343, 27);
            this.dateEndDate.TabIndex = 6;
            this.dateEndDate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến ngày";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm vào giỏ hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng sp";
            // 
            // txtQuantityProduct
            // 
            this.txtQuantityProduct.Location = new System.Drawing.Point(968, 109);
            this.txtQuantityProduct.Name = "txtQuantityProduct";
            this.txtQuantityProduct.Size = new System.Drawing.Size(267, 22);
            this.txtQuantityProduct.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(842, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã giảm giá";
            // 
            // txtPromotionCode
            // 
            this.txtPromotionCode.Location = new System.Drawing.Point(968, 214);
            this.txtPromotionCode.Name = "txtPromotionCode";
            this.txtPromotionCode.Size = new System.Drawing.Size(267, 22);
            this.txtPromotionCode.TabIndex = 11;
            // 
            // Product_CLient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 736);
            this.Controls.Add(this.txtPromotionCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantityProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBeginDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBuyProduct);
            this.Controls.Add(this.cbRentProduct);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_CLient";
            this.Text = "Product_CLient";
            this.Load += new System.EventHandler(this.Product_CLient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet14BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet15BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource coffeChainManagementDBDataSet15BindingSource;
        private Data.CoffeChainManagementDBDataSet15 coffeChainManagementDBDataSet15;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Data.CoffeChainManagementDBDataSet15TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource coffeChainManagementDBDataSet14BindingSource;
        private Data.CoffeChainManagementDBDataSet14 coffeChainManagementDBDataSet14;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Data.CoffeChainManagementDBDataSet14TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDiscontinuedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox cbRentProduct;
        private System.Windows.Forms.CheckBox cbBuyProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBeginDate;
        private System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantityProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPromotionCode;
    }
}