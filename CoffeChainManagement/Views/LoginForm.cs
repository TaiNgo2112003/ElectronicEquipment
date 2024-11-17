using CoffeChainManagement.Db;
using CoffeeChainManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeChainManagement
{
    public partial class LoginForm : Form
    {
        private string connectionString = DbConnection_.DbConfig.ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Optional: removes the border of the form
            this.BackColor = Color.White; // Optional: sets the background color of the form

            // Set the region to make the form's corners rounded
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Change the radius value to adjust the roundness
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            this.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
        public static class CurrentUser
        {
            public static string Username { get; set; }
            public static string Role {  get; set; }    
            
        }
        private string HashPassword(string password)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();    
                for (int i = 0;i<bytes.Length;i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();  
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            
            string username = tbUserName.Text;
            string password = tbPassword.Text;  

            if(tbUserName.Text == "" )
            {
                MessageBox.Show("Xin hãy nhập UserName");
            }
            if(tbPassword.Text == "")
            {
                MessageBox.Show("Nhập hãy nhập Password!!!");
            }
            string role = checkCorrectAccount(username,password); ;
            if (!string.IsNullOrEmpty(role))
            {
                CurrentUser.Username = username;
                CurrentUser.Role = role;    
                if(role == "Admin")
                {
                    this.Hide(); // Ẩn form hiện tại
                    MainPage main = new MainPage();
                    main.ShowDialog();
                    this.Close();
                }
                else if(role == "User")
                {
                    this.Hide(); // Ẩn form hiện tại
                    Main_Form_User user = new Main_Form_User();
                    user.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã được tạo nhưng không được phép đăng nhập, liện hệ admin để được cấp quyền sử dụng phần mềm ");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !!!");
            }
        }

        private void LinkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();    
           
        }
        private string checkCorrectAccount(string username, string password)
        {
            string role = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string hashedPassword = HashPassword(password);
					string query = "SELECT Role FROM Account WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@Username", username);
						command.Parameters.AddWithValue("@Password", hashedPassword);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            role = result.ToString();
                        }
					}
				}
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return role;

        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
            if(checkBox1.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click_1(object sender, EventArgs e)
		{
			foreach (var control in this.Controls)
			{
				switch (control)
				{
					case TextBox textBox:
						textBox.Clear();
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
	}
}
