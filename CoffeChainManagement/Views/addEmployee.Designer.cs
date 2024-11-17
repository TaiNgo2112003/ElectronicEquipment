namespace CoffeChainManagement
{
	partial class addEmployee
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
			this.label1 = new System.Windows.Forms.Label();
			this.fullnameTb = new System.Windows.Forms.TextBox();
			this.emailTb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.phoneNumberTb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.positionTb = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.hireDateTb = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.cbShopID_Name = new System.Windows.Forms.ComboBox();
			this.coffeChainManagementDBDataSet19 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet19();
			this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.shopsTableAdapter = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet19TableAdapters.ShopsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Full name";
			// 
			// fullnameTb
			// 
			this.fullnameTb.Location = new System.Drawing.Point(145, 65);
			this.fullnameTb.Name = "fullnameTb";
			this.fullnameTb.Size = new System.Drawing.Size(282, 22);
			this.fullnameTb.TabIndex = 1;
			// 
			// emailTb
			// 
			this.emailTb.Location = new System.Drawing.Point(145, 124);
			this.emailTb.Name = "emailTb";
			this.emailTb.Size = new System.Drawing.Size(282, 22);
			this.emailTb.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email";
			// 
			// phoneNumberTb
			// 
			this.phoneNumberTb.Location = new System.Drawing.Point(145, 183);
			this.phoneNumberTb.Name = "phoneNumberTb";
			this.phoneNumberTb.Size = new System.Drawing.Size(282, 22);
			this.phoneNumberTb.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phone";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 246);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Shop name";
			// 
			// positionTb
			// 
			this.positionTb.Location = new System.Drawing.Point(145, 307);
			this.positionTb.Name = "positionTb";
			this.positionTb.Size = new System.Drawing.Size(282, 22);
			this.positionTb.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 307);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Position";
			// 
			// hireDateTb
			// 
			this.hireDateTb.Location = new System.Drawing.Point(145, 376);
			this.hireDateTb.Name = "hireDateTb";
			this.hireDateTb.Size = new System.Drawing.Size(282, 22);
			this.hireDateTb.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(52, 376);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Hire Date";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(552, 95);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 60);
			this.button1.TabIndex = 12;
			this.button1.Text = "Add employee";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(552, 183);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 60);
			this.button2.TabIndex = 13;
			this.button2.Text = "Refresh content";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(552, 269);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 60);
			this.button3.TabIndex = 14;
			this.button3.Text = "Out this page";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// cbShopID_Name
			// 
			this.cbShopID_Name.DataSource = this.shopsBindingSource;
			this.cbShopID_Name.DisplayMember = "ShopName";
			this.cbShopID_Name.FormattingEnabled = true;
			this.cbShopID_Name.Location = new System.Drawing.Point(145, 246);
			this.cbShopID_Name.Name = "cbShopID_Name";
			this.cbShopID_Name.Size = new System.Drawing.Size(282, 24);
			this.cbShopID_Name.TabIndex = 15;
			this.cbShopID_Name.ValueMember = "ShopID";
			// 
			// coffeChainManagementDBDataSet19
			// 
			this.coffeChainManagementDBDataSet19.DataSetName = "CoffeChainManagementDBDataSet19";
			this.coffeChainManagementDBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// shopsBindingSource
			// 
			this.shopsBindingSource.DataMember = "Shops";
			this.shopsBindingSource.DataSource = this.coffeChainManagementDBDataSet19;
			// 
			// shopsTableAdapter
			// 
			this.shopsTableAdapter.ClearBeforeFill = true;
			// 
			// addEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 487);
			this.Controls.Add(this.cbShopID_Name);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hireDateTb);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.positionTb);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.phoneNumberTb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.emailTb);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.fullnameTb);
			this.Controls.Add(this.label1);
			this.Name = "addEmployee";
			this.Text = "addEmployee";
			this.Load += new System.EventHandler(this.addEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fullnameTb;
		private System.Windows.Forms.TextBox emailTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox phoneNumberTb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox positionTb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox hireDateTb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cbShopID_Name;
		private Data.CoffeChainManagementDBDataSet19 coffeChainManagementDBDataSet19;
		private System.Windows.Forms.BindingSource shopsBindingSource;
		private Data.CoffeChainManagementDBDataSet19TableAdapters.ShopsTableAdapter shopsTableAdapter;
	}
}