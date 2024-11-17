using CoffeChainManagement.Controller;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CoffeChainManagement.Models;
using CoffeChainManagement.Db;
namespace CoffeChainManagement
{
	public partial class Employee : Form
	{
        private string connectionString = DbConnection_.DbConfig.ConnectionString;

        public Employee()
		{
			InitializeComponent();
		}

		private void Employee_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSetProduct.Product' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
            this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet19.Shops);


        }

        private void button1_Click(object sender, EventArgs e)
		{
			if (employeeGridView.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin của nhân viên này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					// Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu
					foreach (DataGridViewRow row in employeeGridView.SelectedRows)
					{
						var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet3.EmployeeRow;
						if (rowoob != null)
						{
							int ID = rowoob.Id;
							string FullName = rowoob.FullName;
							string Email = rowoob.Email;
							string PhoneNumber = rowoob.Phone;
							int ShopID = rowoob.ShopID;
							string Position = rowoob.Position;
							DateTime dateTime = rowoob.HireDate;

							// Gọi hàm UpdateEmployee với dữ liệu nhân viên cần sửa
							bool success = UpdateEmployee(ID, FullName, Email, PhoneNumber, ShopID, Position, dateTime);

							if (success)
							{
								MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
								// Làm mới dữ liệu trên DataGridView*6
								this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
							}
							else
							{
								MessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn nhân viên để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
        private void buttonSave_Click(object sender, EventArgs e)
        {

           
        }

        private bool UpdateEmployee(int ID, string FullName, string Email, string PhoneNumber, int ShopID, string Position, DateTime dateTime)
		{
			bool success = false;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Sử dụng lệnh UPDATE thay vì INSERT
				string query = "UPDATE Employee SET FullName = @FullName, Email = @Email, Phone = @Phone, ShopID = @ShopID, Position = @Position, HireDate = @HireDate WHERE Id = @ID";
				SqlCommand command = new SqlCommand(query, connection);

				// Thêm các tham số
				command.Parameters.AddWithValue("@FullName", FullName);
				command.Parameters.AddWithValue("@Email", Email);
				command.Parameters.AddWithValue("@Phone", PhoneNumber);
				command.Parameters.AddWithValue("@ShopID", ShopID);
				command.Parameters.AddWithValue("@Position", Position);
				command.Parameters.AddWithValue("@HireDate", dateTime);
				command.Parameters.AddWithValue("@ID", ID);  // Thêm tham số ID

				int rowsAffected = command.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					success = true;
				}
			}
			return success;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem người dùng đã chọn một hàng nào đó chưa
			if (employeeGridView.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên đã chọn ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					// Thực hiện xóa dữ liệu khỏi cơ sở dữ liệu
					foreach (DataGridViewRow row in employeeGridView.SelectedRows)
					{
						var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet3.EmployeeRow;
						if (rowoob != null)
						{
							int employeeId = rowoob.Id;
							bool success = DeleteEmployee(employeeId);
							if (success)
							{
								MessageBox.Show("Đã xóa coffee shop với id là" + employeeId);
								this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);

							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private bool DeleteEmployee(int employeeId)
		{
			bool success = false;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "DELETE FROM Employee WHERE Id = @Id";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@Id", employeeId);

				// Thực thi truy vấn
				int rowsAffected = command.ExecuteNonQuery();

				// Kiểm tra kết quả thực thi
				if (rowsAffected > 0)
				{
					success = true; // Ít nhất một dòng bị ảnh hưởng, tức là dữ liệu đã được xóa
				}
			}
			return success;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			addEmployee addEmployee = new addEmployee();	
			addEmployee.ShowDialog();	
			if(addEmployee.ShowDialog() == DialogResult.OK)
			{
				this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void rewardBtn_Click(object sender, EventArgs e)
		{
			string typeData = string.Empty; // Khởi tạo biến

			if (cbReward.SelectedItem != null)
			{
				typeData = cbReward.SelectedItem.ToString();
				MessageBox.Show("Giá trị đã chọn là: " + typeData);

			}
			else
			{
				MessageBox.Show("Vui lòng chọn lý do nhận thưởng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Thoát khỏi hàm nếu không có lựa chọn
			}

			// Kiểm tra xem có hàng nào được chọn hay không
			if (employeeGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Thoát khỏi hàm nếu không có hàng nào được chọn
			}
			ExportToWord(typeData);

		}
		private void button5_Click(object sender, EventArgs e)
		{
			string typePulishment = string.Empty;

			if (punishmentCb.SelectedItem != null)
			{
				typePulishment = punishmentCb.SelectedItem.ToString();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn lý do nhận hình phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra xem có hàng nào được chọn hay không
			if (employeeGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Thoát khỏi hàm nếu không có hàng nào được chọn
			}
			ExportToWord(typePulishment);
		}
		private void ExportToWord(string typeData)
		{
			
			var wordApp = new Microsoft.Office.Interop.Word.Application();
			Document document = wordApp.Documents.Add();

			//Lý do văn bản nè
			Paragraph paragraph = document.Content.Paragraphs.Add();
			paragraph.Range.Text = "Lý do văn bản: " + typeData;
			paragraph.Range.InsertParagraphAfter();

			// Add date
			Paragraph dateParagraph = document.Content.Paragraphs.Add();
			dateParagraph.Range.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
			dateParagraph.Range.Font.Size = 12;
			dateParagraph.Range.InsertParagraphAfter();

			Table table = document.Tables.Add(paragraph.Range, employeeGridView.SelectedRows.Count + 1, employeeGridView.Columns.Count);
			table.Borders.Enable = 1;

			

			for (int i = 0; i < employeeGridView.Columns.Count; i++)
			{
				table.Cell(1, i + 1).Range.Text = employeeGridView.Columns[i].HeaderText;
			}

			for (int j = 0; j < employeeGridView.SelectedRows.Count; j++)
			{
				DataGridViewRow selectedRow = employeeGridView.SelectedRows[j];
				for (int i = 0; i < employeeGridView.Columns.Count; i++)
				{
					table.Cell(j + 2, i + 1).Range.Text = selectedRow.Cells[i].Value?.ToString() ?? "";
				}
			}

			wordApp.Visible = true; // Hiển thị tài liệu Word
		}

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
			if(checkBox1.Checked)
			{
				panel1.Visible = true;
			}
			else
			{
				panel1.Visible = false;
			}
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // Create a new Employee object based on the form inputs
            Employee_ newEmployee = new Employee_
            {
                FullName = textBoxFullName.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text,
                ShopID = Convert.ToInt32(comboBoxShopID.SelectedValue),  // Assuming you have ShopID as a dropdown
                Position = textBoxPosition.Text,
                HireDate = dateTimePickerHireDate.Value
            };

            // Call Save method from EmployeeController
            EmployeeController controller = new EmployeeController();
            if (controller.Save(newEmployee))
            {
                MessageBox.Show("Đã thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh DataGridView after saving
                this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string typeData = string.Empty; // Khởi tạo biến

            if (cbReward.SelectedItem != null)
            {
                typeData = cbReward.SelectedItem.ToString();
                MessageBox.Show("Giá trị đã chọn là: " + typeData);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn lý do nhận thưởng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm nếu không có lựa chọn
            }

            // Kiểm tra xem có hàng nào được chọn hay không
            if (employeeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm nếu không có hàng nào được chọn
            }
            ExportToWord(typeData);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string typePulishment = string.Empty;

            if (punishmentCb.SelectedItem != null)
            {
                typePulishment = punishmentCb.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lý do nhận hình phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có hàng nào được chọn hay không
            if (employeeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm nếu không có hàng nào được chọn
            }
            ExportToWord(typePulishment);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (employeeGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin của nhân viên này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu
                    foreach (DataGridViewRow row in employeeGridView.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet3.EmployeeRow;
                        if (rowoob != null)
                        {
                            int ID = rowoob.Id;
                            string FullName = rowoob.FullName;
                            string Email = rowoob.Email;
                            string PhoneNumber = rowoob.Phone;
                            int ShopID = rowoob.ShopID;
                            string Position = rowoob.Position;
                            DateTime dateTime = rowoob.HireDate;

                            // Gọi hàm UpdateEmployee với dữ liệu nhân viên cần sửa
                            bool success = UpdateEmployee(ID, FullName, Email, PhoneNumber, ShopID, Position, dateTime);

                            if (success)
                            {
                                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Làm mới dữ liệu trên DataGridView*6
                                this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng nào đó chưa
            if (employeeGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên đã chọn ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa dữ liệu khỏi cơ sở dữ liệu
                    foreach (DataGridViewRow row in employeeGridView.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet3.EmployeeRow;
                        if (rowoob != null)
                        {
                            int employeeId = rowoob.Id;
                            bool success = DeleteEmployee(employeeId);
                            if (success)
                            {
                                MessageBox.Show("Đã xóa coffee shop với id là" + employeeId);
                                this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee addEmployee = new addEmployee();
            addEmployee.ShowDialog();
            if (addEmployee.ShowDialog() == DialogResult.OK)
            {
                this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
            }
        }

        private void addE_Click(object sender, EventArgs e)
        {
            // Create a new Employee object based on the form inputs
            Employee_ newEmployee = new Employee_
            {
                FullName = textBoxFullName.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text,
                ShopID = Convert.ToInt32(comboBoxShopID.SelectedValue),  // Assuming you have ShopID as a dropdown
                Position = textBoxPosition.Text,
                HireDate = dateTimePickerHireDate.Value
            };

            // Call Save method from EmployeeController
            EmployeeController controller = new EmployeeController();
            if (controller.Save(newEmployee))
            {
                MessageBox.Show("Đã thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh DataGridView after saving
                this.employeeTableAdapter.Fill(this.coffeChainManagementDBDataSet3.Employee);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }

}
