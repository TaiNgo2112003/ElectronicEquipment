using CoffeChainManagement.Db;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
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
	public partial class btnExportInventory : Form
	{
        private string connectionString = DbConnection_.DbConfig.ConnectionString;

        public btnExportInventory()
		{
			InitializeComponent();
		}

		private void inventoryForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet20.Inventory' table. You can move, or remove it, as needed.
			this.inventoryTableAdapter3.Fill(this.coffeChainManagementDBDataSet20.Inventory);
			// TODO: This line of code loads data into the 'inventoryDataset.Inventory' table. You can move, or remove it, as needed.
			this.inventoryTableAdapter2.Fill(this.inventoryDataset.Inventory);
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet10.GetInventoryWithDetails' table. You can move, or remove it, as needed.
			this.getInventoryWithDetailsTableAdapter1.Fill(this.coffeChainManagementDBDataSet10.GetInventoryWithDetails);
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet9.GetInventoryWithDetails' table. You can move, or remove it, as needed.
			this.getInventoryWithDetailsTableAdapter.Fill(this.coffeChainManagementDBDataSet9.GetInventoryWithDetails);
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet8.Inventory' table. You can move, or remove it, as needed.
			this.inventoryTableAdapter1.Fill(this.coffeChainManagementDBDataSet8.Inventory);
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet7.Inventory' table. You can move, or remove it, as needed.
			this.inventoryTableAdapter.Fill(this.coffeChainManagementDBDataSet7.Inventory);
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet6.Category' table. You can move, or remove it, as needed.
			this.categoryTableAdapter.Fill(this.coffeChainManagementDBDataSet6.Category);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (cbExportType.SelectedItem != null)
			{
				string exportType = cbExportType.SelectedItem.ToString();
				if (exportType == "Word")
				{
					ExportToWord();
				}
				else if (exportType == "Excel")
				{
					ExportToExcel();
				}
			}
			else
			{
				MessageBox.Show("Hãy chọn 1 kiểu dữ liệu trước khi xuất tồn kho !");
			}
		}
		private void ExportToWord()
		{
			if (inventoryGridView.Rows.Count == 0 || inventoryGridView.Columns.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var wordApp = new Microsoft.Office.Interop.Word.Application();
			Document document = wordApp.Documents.Add();

			// Tạo bảng trong Word với số hàng và cột tương ứng
			Table table = document.Tables.Add(document.Range(0, 0), inventoryGridView.Rows.Count + 1, inventoryGridView.Columns.Count);
			table.Borders.Enable = 1;

			// Ghi tiêu đề cột
			for (int i = 0; i < inventoryGridView.Columns.Count; i++)
			{
				table.Cell(1, i + 1).Range.Text = inventoryGridView.Columns[i].HeaderText;
			}

			// Ghi dữ liệu vào bảng
			for (int j = 0; j < inventoryGridView.Rows.Count; j++)
			{
				for (int i = 0; i < inventoryGridView.Columns.Count; i++)
				{
					table.Cell(j + 2, i + 1).Range.Text = inventoryGridView.Rows[j].Cells[i].Value?.ToString() ?? "";
				}
			}

			wordApp.Visible = true;
		}

		private void ExportToExcel()
		{
			if (inventoryGridView.Rows.Count == 0 || inventoryGridView.Columns.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var excelApp = new Microsoft.Office.Interop.Excel.Application();
			Workbook workbook = excelApp.Workbooks.Add();
			Worksheet worksheet = workbook.Sheets[1];

			// Ghi tiêu đề cột
			for (int i = 0; i < inventoryGridView.Columns.Count; i++)
			{
				worksheet.Cells[1, i + 1] = inventoryGridView.Columns[i].HeaderText;
			}

			// Ghi dữ liệu
			for (int i = 0; i < inventoryGridView.Rows.Count; i++)
			{
				for (int j = 0; j < inventoryGridView.Columns.Count; j++)
				{
					// Sử dụng Cells[i + 2, j + 1] vì hàng đầu tiên là tiêu đề
					worksheet.Cells[i + 2, j + 1] = inventoryGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
				}
			}

			excelApp.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (inventoryGridView.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin tồn kho này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					foreach (DataGridViewRow row in inventoryGridView.SelectedRows)
					{
						try
						{
							var rowInventory = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet20.InventoryRow;
							if (rowInventory != null)
							{
								int id = rowInventory.Id;
								int productId = rowInventory.ProductId;
								int shopId = rowInventory.ShopID;
								int quantity = rowInventory.Quantity;
								DateTime lastUpdated = DateTime.Now;  // Thời gian hiện tại khi cập nhật

								bool success = UpdateInventory(id, productId, shopId, quantity, lastUpdated);
								if (success)
								{
									MessageBox.Show("Đã cập nhật thông tin tồn kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
									// Cập nhật lại dữ liệu trên DataGridView
									this.inventoryTableAdapter.Fill(this.coffeChainManagementDBDataSet7.Inventory);
								}
								else
								{
									throw new Exception("Cập nhật thông tin tồn kho thất bại.");
								}
							}
							else
							{
								throw new Exception("Không thể chuyển đổi dữ liệu từ hàng được chọn thành InventoryRow.");
							}
						}
						catch (SqlException ex)
						{
							// Ném ngoại lệ cơ sở dữ liệu với thông tin chi tiết
							throw new Exception("Lỗi cơ sở dữ liệu: " + ex.Message, ex);
						}
						catch (InvalidCastException ex)
						{
							// Ném ngoại lệ khi chuyển đổi kiểu dữ liệu không thành công
							throw new Exception("Lỗi chuyển đổi dữ liệu: " + ex.Message, ex);
						}
						catch (Exception ex)
						{
							// Ném ngoại lệ chung cho các lỗi khác
							throw new Exception("Đã xảy ra lỗi: " + ex.Message, ex);
						}

					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hàng tồn kho để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private bool UpdateInventory(int id, int productId, int shopId, int quantity, DateTime lastUpdated)
		{
			bool success = false;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Câu lệnh UPDATE để cập nhật dữ liệu
				string query = "UPDATE Inventory SET ProductId = @ProductId, ShopID = @ShopId, Quantity = @Quantity, LastUpdated = @LastUpdated WHERE Id = @Id";
				SqlCommand command = new SqlCommand(query, connection);

				// Gán tham số
				command.Parameters.AddWithValue("@ProductId", productId);
				command.Parameters.AddWithValue("@ShopId", shopId);
				command.Parameters.AddWithValue("@Quantity", quantity);
				command.Parameters.AddWithValue("@LastUpdated", lastUpdated);
				command.Parameters.AddWithValue("@Id", id);  // Tham số Id để xác định bản ghi cần cập nhật

				int rowsAffected = command.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					success = true;
				}
			}
			return success;
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbExportType.SelectedItem != null)
            {
                string exportType = cbExportType.SelectedItem.ToString();
                if (exportType == "Word")
                {
                    ExportToWord();
                }
                else if (exportType == "Excel")
                {
                    ExportToExcel();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 kiểu dữ liệu trước khi xuất tồn kho !");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin tồn kho này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in inventoryGridView.SelectedRows)
                    {
                        try
                        {
                            var rowInventory = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet20.InventoryRow;
                            if (rowInventory != null)
                            {
                                int id = rowInventory.Id;
                                int productId = rowInventory.ProductId;
                                int shopId = rowInventory.ShopID;
                                int quantity = rowInventory.Quantity;
                                DateTime lastUpdated = DateTime.Now;  // Thời gian hiện tại khi cập nhật

                                bool success = UpdateInventory(id, productId, shopId, quantity, lastUpdated);
                                if (success)
                                {
                                    MessageBox.Show("Đã cập nhật thông tin tồn kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Cập nhật lại dữ liệu trên DataGridView
                                    this.inventoryTableAdapter.Fill(this.coffeChainManagementDBDataSet7.Inventory);
                                }
                                else
                                {
                                    throw new Exception("Cập nhật thông tin tồn kho thất bại.");
                                }
                            }
                            else
                            {
                                throw new Exception("Không thể chuyển đổi dữ liệu từ hàng được chọn thành InventoryRow.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Ném ngoại lệ cơ sở dữ liệu với thông tin chi tiết
                            throw new Exception("Lỗi cơ sở dữ liệu: " + ex.Message, ex);
                        }
                        catch (InvalidCastException ex)
                        {
                            // Ném ngoại lệ khi chuyển đổi kiểu dữ liệu không thành công
                            throw new Exception("Lỗi chuyển đổi dữ liệu: " + ex.Message, ex);
                        }
                        catch (Exception ex)
                        {
                            // Ném ngoại lệ chung cho các lỗi khác
                            throw new Exception("Đã xảy ra lỗi: " + ex.Message, ex);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng tồn kho để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
