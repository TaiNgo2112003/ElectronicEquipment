namespace CoffeChainManagement
{
	partial class shippingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet17 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet17();
            this.shippingTableAdapter = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet17TableAdapters.ShippingTableAdapter();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.shippingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet18 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet18();
            this.shippingTableAdapter1 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet18TableAdapters.ShippingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.shippingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet17BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet17BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet18BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // shippingBindingSource
            // 
            this.shippingBindingSource.DataMember = "Shipping";
            this.shippingBindingSource.DataSource = this.coffeChainManagementDBDataSet17;
            // 
            // coffeChainManagementDBDataSet17
            // 
            this.coffeChainManagementDBDataSet17.DataSetName = "CoffeChainManagementDBDataSet17";
            this.coffeChainManagementDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shippingTableAdapter
            // 
            this.shippingTableAdapter.ClearBeforeFill = true;
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(25, 302);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1044, 443);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // shippingBindingSource1
            // 
            this.shippingBindingSource1.DataMember = "Shipping";
            this.shippingBindingSource1.DataSource = this.coffeChainManagementDBDataSet18;
            // 
            // coffeChainManagementDBDataSet18
            // 
            this.coffeChainManagementDBDataSet18.DataSetName = "CoffeChainManagementDBDataSet18";
            this.coffeChainManagementDBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shippingTableAdapter1
            // 
            this.shippingTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(417, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "VỊ TRÍ ĐẶT HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeChainManagement.Properties.Resources.shippingIcon;
            this.pictureBox1.Location = new System.Drawing.Point(1075, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 400);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 18;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.shippingAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.shippingDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shippingBindingSource4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1600, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_2);
            // 
            // shippingBindingSource2
            // 
            this.shippingBindingSource2.DataMember = "Shipping";
            this.shippingBindingSource2.DataSource = this.coffeChainManagementDBDataSet17;
            // 
            // coffeChainManagementDBDataSet17BindingSource
            // 
            this.coffeChainManagementDBDataSet17BindingSource.DataSource = this.coffeChainManagementDBDataSet17;
            this.coffeChainManagementDBDataSet17BindingSource.Position = 0;
            // 
            // shippingBindingSource3
            // 
            this.shippingBindingSource3.DataMember = "Shipping";
            this.shippingBindingSource3.DataSource = this.coffeChainManagementDBDataSet17BindingSource;
            // 
            // coffeChainManagementDBDataSet18BindingSource
            // 
            this.coffeChainManagementDBDataSet18BindingSource.DataSource = this.coffeChainManagementDBDataSet18;
            this.coffeChainManagementDBDataSet18BindingSource.Position = 0;
            // 
            // shippingBindingSource4
            // 
            this.shippingBindingSource4.DataMember = "Shipping";
            this.shippingBindingSource4.DataSource = this.coffeChainManagementDBDataSet18BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // shippingAddressDataGridViewTextBoxColumn
            // 
            this.shippingAddressDataGridViewTextBoxColumn.DataPropertyName = "ShippingAddress";
            this.shippingAddressDataGridViewTextBoxColumn.HeaderText = "ShippingAddress";
            this.shippingAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shippingAddressDataGridViewTextBoxColumn.Name = "shippingAddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // shippingDateDataGridViewTextBoxColumn
            // 
            this.shippingDateDataGridViewTextBoxColumn.DataPropertyName = "ShippingDate";
            this.shippingDateDataGridViewTextBoxColumn.HeaderText = "ShippingDate";
            this.shippingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shippingDateDataGridViewTextBoxColumn.Name = "shippingDateDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            // 
            // shippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 778);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gMapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "shippingForm";
            this.Text = "shippingForm";
            this.Load += new System.EventHandler(this.shippingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet17BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet18BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Data.CoffeChainManagementDBDataSet17 coffeChainManagementDBDataSet17;
		private System.Windows.Forms.BindingSource shippingBindingSource;
		private Data.CoffeChainManagementDBDataSet17TableAdapters.ShippingTableAdapter shippingTableAdapter;
		private GMap.NET.WindowsForms.GMapControl gMapControl1;
		private Data.CoffeChainManagementDBDataSet18 coffeChainManagementDBDataSet18;
		private System.Windows.Forms.BindingSource shippingBindingSource1;
		private Data.CoffeChainManagementDBDataSet18TableAdapters.ShippingTableAdapter shippingTableAdapter1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shippingBindingSource4;
        private System.Windows.Forms.BindingSource coffeChainManagementDBDataSet18BindingSource;
        private System.Windows.Forms.BindingSource shippingBindingSource2;
        private System.Windows.Forms.BindingSource coffeChainManagementDBDataSet17BindingSource;
        private System.Windows.Forms.BindingSource shippingBindingSource3;
    }
}