using CoffeChainManagement.Db;
using Gmap.net.Enums;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace CoffeChainManagement
{
	public partial class addEmployee : Form
	{
		private string connectionString = DbConnection_.DbConfig.ConnectionString;
		public addEmployee()
		{
			InitializeComponent();
		}

		private void addEmployee_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet19.Shops' table. You can move, or remove it, as needed.
			this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet19.Shops);

		}

		private void button1_Click(object sender, EventArgs e)
		{

			string fullname = fullnameTb.Text;
			string email = emailTb.Text;
			string phone = phoneNumberTb.Text;
			int shopname = Convert.ToInt32(cbShopID_Name.SelectedValue);
			string position = positionTb.Text;
			string hiredate = hireDateTb.Text;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "INSERT INTO [dbo].[Employee] ([FullName], [Email] , [Phone] , [ShopID], [Position], [HireDate]) " +
					"VALUES (@FullName, @Email, @Phone, @ShopID, @Position, @HireDate)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@FullName", fullname);
				command.Parameters.AddWithValue("@Email", email);
				command.Parameters.AddWithValue("@Phone", phone);
				command.Parameters.AddWithValue("@ShopID", shopname); 
				command.Parameters.AddWithValue("@Position", position);
				command.Parameters.AddWithValue("@HireDate", hiredate);


				int rowsAffected = command.ExecuteNonQuery();

				if (rowsAffected > 0)
				{
					MessageBox.Show("Thêm thành công 1 nv !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Thêm không thành công!");
				}
			}
		}
	}
}
