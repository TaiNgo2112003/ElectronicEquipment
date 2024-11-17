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
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace CoffeChainManagement
{
    public partial class mainForm : Form
    {
        private string connectionString = DbConnection_.DbConfig.ConnectionString;
        private StoreController storeController;    

        public mainForm()
        {
            InitializeComponent();
            storeController = new StoreController();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet.Shops' table. You can move, or remove it, as needed.
            this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet.Shops);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCoffeeShop addCoffeeShop = new AddCoffeeShop();
            if (addCoffeeShop.ShowDialog() == DialogResult.OK)
            {
                addCoffeeShop.Show();
            }
            this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet.Shops);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng nào đó chưa
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị thông báo xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa dữ liệu khỏi cơ sở dữ liệu
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet.ShopsRow;
                        if (rowoob != null)
                        {
                            int coffeeShopID = rowoob.ShopID;
                            // Gọi hàm xóa dữ liệu từ cơ sở dữ liệu
                            bool success = DeleteCoffeeShops(coffeeShopID);
                            if (success)
                            {
                                MessageBox.Show("Đã xóa coffee shop với id là" + coffeeShopID);
                                this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet.Shops);

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
        private bool DeleteCoffeeShops(int coffeeShopID)
        {
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Shops WHERE ShopID = @ShopID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShopID", coffeeShopID);

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận chỉnh sửa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    // Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu


                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var shop = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet.ShopsRow;
                        if (shop != null)
                        {
                            Shops updatedShop = new Shops {
                                ShopID = shop.ShopID,
                                ShopName = shop.ShopName,
                                Address = shop.Address,
                                PhoneNumber = shop.PhoneNumber,
                                OpeningHours = shop.OpeningHours,
                                Revenue = shop.Revenue,
                                ImagePath = shop.ImagePath,
                                Description = shop.Description
                            };


                            bool success = storeController.Update(updatedShop);
                            if (success)
                            {
                                MessageBox.Show("Đã cập nhật thông tin store thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet.Shops);

                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin store!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }



                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool UpdateCoffeeShop(int coffeeShopID, string shopName, string address, string phoneNumber, string openingHours, decimal revenue, string imagePath, string description)
        {

            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Shops SET ShopName = @ShopName, Address = @Address, Revenue = @Revenue, ImagePath = @ImagePath WHERE ShopID = @coffeeShopID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@coffeeShopID", coffeeShopID);
                command.Parameters.AddWithValue("@ShopName", shopName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@openingHours", openingHours);
                command.Parameters.AddWithValue("@Revenue", revenue);
                command.Parameters.AddWithValue("@ImagePath", imagePath);
                command.Parameters.AddWithValue("@description", description);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }
            return success;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet.ShopsRow;
                    if (rowoob != null)
                    {
                        int coffeeShopID = rowoob.ShopID;
                        // Tạo instance của form DetailCoffeeShop
                        DetailCoffeeShop detailForm = new DetailCoffeeShop();
                        // Truyền ShopID vào thuộc tính ShopID của form DetailCoffeeShop
                        detailForm.ShopID = coffeeShopID;
                        // Hiển thị form DetailCoffeeShop
                        detailForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết!");
            }
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

            Shops newShop = new Shops
            {
                ShopName = tbShopName.Text,
                Address = tbAddress.Text,
                PhoneNumber = tbPhoneNumber.Text,
                OpeningHours = tbOpeningHours.Text,
                Revenue = decimal.Parse(tbRevenue.Text), // Kiểm tra và xử lý lỗi nếu cần
                ImagePath = tbImagePath.Text,
                Description = tbDescription.Text
            };

            bool success = storeController.Save(newShop);
            if (success)
            {
                MessageBox.Show("Tạo thành công 1 shop !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo không thành công!");
            }
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
        private void pathBtn_Click_1(object sender, EventArgs e)
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            string ShopName = tbShopName.Text;
            string Address = tbAddress.Text;
            string PhoneNumber = tbPhoneNumber.Text;
            string OpeningHours = tbOpeningHours.Text;
            string Revenue = tbRevenue.Text;
            string ImagePath = tbImagePath.Text;
            string Description = tbDescription.Text;

            Shops newShop = new Shops
            {
                ShopName = tbShopName.Text,
                Address = tbAddress.Text,
                PhoneNumber = tbPhoneNumber.Text,
                OpeningHours = tbOpeningHours.Text,
                Revenue = decimal.Parse(tbRevenue.Text), // Kiểm tra và xử lý lỗi nếu cần
                ImagePath = tbImagePath.Text,
                Description = tbDescription.Text
            };

            bool success = storeController.Save(newShop);
            if (success)
            {
                MessageBox.Show("Tạo thành công 1 store !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo không thành công!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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