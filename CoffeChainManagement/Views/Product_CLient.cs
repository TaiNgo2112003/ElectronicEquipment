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

namespace CoffeChainManagement.Views
{
    public partial class Product_CLient : Form
    {
        private string connectionString = DbConnection_.DbConfig.ConnectionString;

        public Product_CLient()
        {
            InitializeComponent();
        }

        private void Product_CLient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet14.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product);
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet15.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.coffeChainManagementDBDataSet15.Category);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantityProduct = Int32.Parse(txtQuantityProduct.Text);   // Lấy số lượng sản phẩm từ input
            string codePromotion = txtPromotionCode.Text;                // Lấy mã giảm giá từ input
            var isRent = cbRentProduct.Checked;                          // Kiểm tra xem sản phẩm có được thuê hay không
            DateTime beginDay = dateBeginDate.Value;                     // Lấy ngày bắt đầu thuê
            DateTime endDay = dateEndDate.Value;                         // Lấy ngày kết thúc thuê
            int UserID = 1;  // Giả sử bạn đã lấy được UserID từ hệ thống, ví dụ từ session

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này vào giỏ hàng?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int productId = Convert.ToInt32(row.Cells["Id"].Value);  // Lấy ProductID từ hàng được chọn trong DataGridView
                            int unitPrice = Convert.ToInt32(row.Cells[2].Value);
                            // Tạo chuỗi truy vấn để thêm sản phẩm vào giỏ hàng
                            string query = "INSERT INTO Cart (UserID, ProductID, Quantity, IsRent, StartDate, EndDate, DiscountCode, CreatedAt, Price) " +
                                           "VALUES (@UserID, @ProductID, @Quantity, @IsRent, @StartDate, @EndDate, @DiscountCode, @CreatedAt, @Price)";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                // Thêm các tham số vào câu truy vấn
                                cmd.Parameters.AddWithValue("@UserID", UserID);
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@Quantity", quantityProduct);
                                cmd.Parameters.AddWithValue("@IsRent", isRent);
                                cmd.Parameters.AddWithValue("@StartDate", isRent ? (object)beginDay : DBNull.Value);   // Chỉ thêm ngày nếu thuê
                                cmd.Parameters.AddWithValue("@EndDate", isRent ? (object)endDay : DBNull.Value);       // Chỉ thêm ngày nếu thuê
                                cmd.Parameters.AddWithValue("@DiscountCode", string.IsNullOrEmpty(codePromotion) ? DBNull.Value : (object)codePromotion);  // Mã giảm giá có thể là NULL
                                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);  // Thời gian hiện tại
                                cmd.Parameters.AddWithValue("@Price", unitPrice * quantityProduct);
                                // Thực thi lệnh SQL
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để thêm vào giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void cbRentProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRentProduct.Checked)
            {
                dateBeginDate.Visible = true;
                dateEndDate.Visible = true;
                label1.Visible = true;
                label2.Visible  = true;
            }
            else
            {
                dateBeginDate.Visible = false;
                dateEndDate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
