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
    public partial class DetailCoffeeShop : Form
    {
        // Thuộc tính công khai để lưu trữ ShopID
        public int ShopID { get; set; }

        // Chuỗi kết nối đến cơ sở dữ liệu
        private string connectionString = DbConnection_.DbConfig.ConnectionString;

        public DetailCoffeeShop()
        {
            InitializeComponent();
        }

        // Sự kiện Load của form DetailCoffeeShop
        private void DetailCoffeeShop_Load(object sender, EventArgs e)
        {
            // Sử dụng ShopID để truy vấn cơ sở dữ liệu và điền dữ liệu vào các TextBox
            LoadShopInfo();
        }

        // Phương thức để tải thông tin cửa hàng từ cơ sở dữ liệu và điền dữ liệu vào các TextBox
        private void LoadShopInfo()
        {
            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu truy vấn SQL để lấy thông tin cửa hàng dựa trên ShopID
                string query = "SELECT * FROM Shops WHERE ShopID = @ShopID";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@ShopID", ShopID);

                    // Thực thi câu truy vấn và đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Điền dữ liệu vào các TextBox tương ứng
                            tbShopName.Text = reader["ShopName"].ToString();
                            tbAddress.Text = reader["Address"].ToString();
                            tbPhoneNumber.Text = reader["PhoneNumber"].ToString();
                            tbOpeningHours.Text = reader["OpeningHours"].ToString();
                            tbRevenue.Text = reader["Revenue"].ToString();
                            tbDescription.Text = reader["Description"].ToString();
                            // Lấy đường dẫn của ảnh từ cột ImagePath
                            string imagePath = reader["ImagePath"].ToString();
                            if (!string.IsNullOrEmpty(imagePath))
                            {
                                // Kiểm tra xem đường dẫn ảnh tồn tại
                                if (System.IO.File.Exists(imagePath))
                                {
                                    // Load và hiển thị ảnh trong PictureBox
                                    pbImage.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    // Nếu không tìm thấy ảnh, hiển thị một thông báo hoặc một ảnh mặc định
                                    MessageBox.Show("Không tìm thấy ảnh!");
                                }
                            }
                            else
                            {
                                // Nếu không có đường dẫn ảnh, hiển thị một thông báo hoặc một ảnh mặc định
                                MessageBox.Show("Không có ảnh!");
                            }
                        }
                    }
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void pbImage_Click(object sender, EventArgs e)
		{

		}
	}
}