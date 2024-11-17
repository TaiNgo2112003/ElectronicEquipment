using CoffeChainManagement;
using CoffeChainManagement.Controller;
using CoffeChainManagement.Db;
using CoffeChainManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeChainManagement
{
    public partial class RegisterForm : Form
    {
        public static string connectionString = DbConnection_.DbConfig.ConnectionString;
        private AccountController accountController = new AccountController();

        public RegisterForm()
        {
            InitializeComponent();
            // Gán sự kiện Load của form cho phương thức RegisterForm_Load
            this.Load += new EventHandler(RegisterForm_Load);
        }
        private string HashPassword(string password)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes =  sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));   
                StringBuilder builder = new StringBuilder();
                for(int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Đặt bất kỳ mã nào bạn muốn thực thi khi form được tải lên ở đây
        }



        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                FullName = txtFullName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                Role = "User"
            };

            bool isSaved = accountController.Save(account);

            if (isSaved)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công!");
            }
        }


        private void button1_Click(object sender, EventArgs e)
		{
			foreach (var control in this.Controls)////////////
			{/////////////////
				switch (control)
				{
					case TextBox textBox:
						textBox.Clear();/////////////////////////////////////////////////////////////////////
						break;
					case ComboBox comboBox:
						comboBox.SelectedIndex = -1;
						break;
					case CheckBox checkBox:
						checkBox.Checked = false;
						break;
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
    }
}
