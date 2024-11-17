namespace CoffeChainManagement
{
    partial class accountForm
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
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet2 = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet2();
            this.accountTableAdapter = new CoffeChainManagement.Data.CoffeChainManagementDBDataSet2TableAdapters.AccountTableAdapter();
            this.dataGridViewAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeChainManagementDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSetRoleAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteN = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.coffeChainManagementDBDataSet2;
            // 
            // coffeChainManagementDBDataSet2
            // 
            this.coffeChainManagementDBDataSet2.DataSetName = "CoffeChainManagementDBDataSet2";
            this.coffeChainManagementDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewAccount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccount.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccount.ColumnHeadersHeight = 18;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.roleDataGridViewTextBoxColumn1});
            this.dataGridViewAccount.DataSource = this.accountBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowHeadersVisible = false;
            this.dataGridViewAccount.RowHeadersWidth = 51;
            this.dataGridViewAccount.RowTemplate.Height = 24;
            this.dataGridViewAccount.Size = new System.Drawing.Size(1197, 376);
            this.dataGridViewAccount.TabIndex = 3;
            this.dataGridViewAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAccount.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGridViewAccount.ThemeStyle.ReadOnly = false;
            this.dataGridViewAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAccount.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            // 
            // roleDataGridViewTextBoxColumn1
            // 
            this.roleDataGridViewTextBoxColumn1.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn1.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn1.Name = "roleDataGridViewTextBoxColumn1";
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "Account";
            this.accountBindingSource1.DataSource = this.coffeChainManagementDBDataSet2BindingSource;
            // 
            // coffeChainManagementDBDataSet2BindingSource
            // 
            this.coffeChainManagementDBDataSet2BindingSource.DataSource = this.coffeChainManagementDBDataSet2;
            this.coffeChainManagementDBDataSet2BindingSource.Position = 0;
            // 
            // btnSetRoleAccount
            // 
            this.btnSetRoleAccount.BorderRadius = 12;
            this.btnSetRoleAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetRoleAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetRoleAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetRoleAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetRoleAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetRoleAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetRoleAccount.ForeColor = System.Drawing.Color.White;
            this.btnSetRoleAccount.Location = new System.Drawing.Point(214, 552);
            this.btnSetRoleAccount.Name = "btnSetRoleAccount";
            this.btnSetRoleAccount.Size = new System.Drawing.Size(201, 52);
            this.btnSetRoleAccount.TabIndex = 19;
            this.btnSetRoleAccount.Text = "Edit Account";
            this.btnSetRoleAccount.Click += new System.EventHandler(this.btnSetRoleAccount_Click);
            // 
            // btnDeleteN
            // 
            this.btnDeleteN.BorderRadius = 12;
            this.btnDeleteN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteN.FillColor = System.Drawing.Color.Red;
            this.btnDeleteN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteN.ForeColor = System.Drawing.Color.White;
            this.btnDeleteN.Location = new System.Drawing.Point(515, 552);
            this.btnDeleteN.Name = "btnDeleteN";
            this.btnDeleteN.Size = new System.Drawing.Size(201, 52);
            this.btnDeleteN.TabIndex = 20;
            this.btnDeleteN.Text = "Delete Account";
            this.btnDeleteN.Click += new System.EventHandler(this.btnDeleteN_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 668);
            this.Controls.Add(this.btnDeleteN);
            this.Controls.Add(this.btnSetRoleAccount);
            this.Controls.Add(this.dataGridViewAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "accountForm";
            this.Text = "accountForm";
            this.Load += new System.EventHandler(this.accountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeChainManagementDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Data.CoffeChainManagementDBDataSet2 coffeChainManagementDBDataSet2;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Data.CoffeChainManagementDBDataSet2TableAdapters.AccountTableAdapter accountTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private System.Windows.Forms.BindingSource coffeChainManagementDBDataSet2BindingSource;
        private Guna.UI2.WinForms.Guna2Button btnSetRoleAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}