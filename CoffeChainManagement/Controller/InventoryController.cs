using CoffeChainManagement.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using CoffeChainManagement.Db;
namespace CoffeChainManagement.Controller
{
    internal class InventoryController : IController<Promotion>
    {
        public static string _connectionString = DbConnection_.DbConfig.ConnectionString;

        public bool Delete(Promotion entity)
        {
            throw new NotImplementedException();
        }

        public bool isValidate(Promotion entity)
        {
            throw new NotImplementedException();
        }

        public bool Save(Promotion entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Promotion entity)
        {
            bool success = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Inventory SET ProductId = @ProductId, ShopID = @ShopId, Quantity = @Quantity, LastUpdated = @LastUpdated WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductId", entity.Id);
                command.Parameters.AddWithValue("@Quantity", entity.Discount);
                command.Parameters.AddWithValue("@LastUpdated", entity.EndDate);
                command.Parameters.AddWithValue("@Id", entity.Id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }
            return success;
        }

        public void ExportToWord(DataGridView inventoryGridView)
        {
            if (inventoryGridView.Rows.Count == 0 || inventoryGridView.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Document document = wordApp.Documents.Add();
            Table table = document.Tables.Add(document.Range(0, 0), inventoryGridView.Rows.Count + 1, inventoryGridView.Columns.Count);
            table.Borders.Enable = 1;

            for (int i = 0; i < inventoryGridView.Columns.Count; i++)
            {
                table.Cell(1, i + 1).Range.Text = inventoryGridView.Columns[i].HeaderText;
            }

            for (int j = 0; j < inventoryGridView.Rows.Count; j++)
            {
                for (int i = 0; i < inventoryGridView.Columns.Count; i++)
                {
                    table.Cell(j + 2, i + 1).Range.Text = inventoryGridView.Rows[j].Cells[i].Value?.ToString() ?? "";
                }
            }

            wordApp.Visible = true;
        }

        public void ExportToExcel(DataGridView inventoryGridView)
        {
            if (inventoryGridView.Rows.Count == 0 || inventoryGridView.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];

            for (int i = 0; i < inventoryGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = inventoryGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < inventoryGridView.Rows.Count; i++)
            {
                for (int j = 0; j < inventoryGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = inventoryGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            excelApp.Visible = true;
        }


    }
}
