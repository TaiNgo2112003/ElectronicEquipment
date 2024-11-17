using CoffeChainManagement.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeChainManagement
{
    public partial class AddCoffeeShop : Form
    {
        public static string connectionString = DbConnection_.DbConfig.ConnectionString;

        public AddCoffeeShop()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                string ShopName = tbShopName.Text;
                string Address = tbAddress.Text;
                string PhoneNumber = tbPhoneNumber.Text;
                string OpeningHours = tbOpeningHours.Text;
                string Revenue = tbRevenue.Text;
                string ImagePath = tbImagePath.Text;
                string Description = tbDescription.Text;    

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Shops (ShopName, Address, PhoneNumber, OpeningHours, Revenue, ImagePath, Description) " +
                                   "VALUES (@ShopName, @Address, @PhoneNumber, @OpeningHours, @Revenue, @ImagePath, @Description)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ShopName", ShopName);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@OpeningHours", OpeningHours);
                    command.Parameters.AddWithValue("@Revenue", Revenue);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    command.Parameters.AddWithValue("@Description", Description);

                int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tạo thành công 1 shop !");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tạo không thành công!");
                    }
                }
            
        }

		private void tbImagePath_TextChanged(object sender, EventArgs e)
		{

		}

		private void imgPathButton_Click(object sender, EventArgs e)
		{

          
		}

		private void pathBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All Files (*.*)|*.*";
			openFileDialog.InitialDirectory = @"C:\";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string pathFile = openFileDialog.FileName;
				tbImagePath.Text = pathFile;
                pbImage.Image = Image.FromFile(pathFile);

			}
            else
            {
				MessageBox.Show("Không tìm thấy path file !");
			}
		}

		private void btnOut_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
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

		private void AddCoffeeShop_Load(object sender, EventArgs e)
		{

		}
	}
}
