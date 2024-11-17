using CoffeChainManagement.Controller;
using CoffeChainManagement.Db;
using CoffeChainManagement.Icon;
using CoffeChainManagement.Models;
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
    public partial class accountForm : Form
    {
        public static string connectionString = DbConnection_.DbConfig.ConnectionString;
        private AccountController accountController = new AccountController();

        public accountForm()
        {
            InitializeComponent();
        }

        private void accountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet2.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.coffeChainManagementDBDataSet2.Account);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
        private bool DeleteAccount(int Id)
        {
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Account WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng nào đó chưa
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                // Hiển thị thông báo xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa user đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa dữ liệu khỏi cơ sở dữ liệu
                    foreach (DataGridViewRow row in dataGridViewAccount.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet2.AccountRow;
                        if (rowoob != null)
                        {
                            int coffeeShopID = rowoob.ID;
                            // Gọi hàm xóa dữ liệu từ cơ sở dữ liệu
                            bool success = DeleteAccount(coffeeShopID);
                            if (success)
                            {
                                MessageBox.Show("Đã xóa user với id là" + coffeeShopID);
                                this.accountTableAdapter.Fill(this.coffeChainManagementDBDataSet2.Account);
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
        private bool UpdateAccount(int Id, string User, string Email, string FullName, string PhoneNumber, string Address, string Role)
        {

            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Account SET Email = @Email, FullName = @FullName, PhoneNumber = @PhoneNumber, Address = @Address, Role= @Role WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@User", User);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@FullName", FullName);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Role", Role);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }
            return success;
        }

        private void btnSetRole_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận chỉnh sửa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu
                    foreach (DataGridViewRow row in dataGridViewAccount.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet2.AccountRow;
                        if (rowoob != null)
                        {
                            int ID = rowoob.ID;
                            string Username = rowoob.Username;
                            string Email = rowoob.Email;
                            string FullName = rowoob.FullName;
                            string PhoneNumber = rowoob.PhoneNumber;
                            string Address = rowoob.Address;
                            string Role = rowoob.Role;
                            bool success = UpdateAccount(ID, Username, Email, FullName, PhoneNumber, Address, Role);
                            if (success)
                            {
                                MessageBox.Show("Đã update user với id là" + ID);
                                this.accountTableAdapter.Fill(this.coffeChainManagementDBDataSet2.Account);
                            }
                            else
                            {
                                MessageBox.Show("CÓ lõi xảy ra  ");

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

        private void btnDeleteN_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa user đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewAccount.SelectedRows)
                    {
                        var rowObj = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet2.AccountRow;
                        if (rowObj != null)
                        {
                            int accountId = rowObj.ID;
                            var account = new Account { ID = accountId };

                            if (accountController.Delete(account))
                            {
                                MessageBox.Show($"Đã xóa user với ID {accountId}");
                                this.accountTableAdapter.Fill(this.coffeChainManagementDBDataSet2.Account);
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công.");
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

        private void btnSetRoleAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewAccount.SelectedRows)
                    {
                        var rowObj = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet2.AccountRow;
                        if (rowObj != null)
                        {
                            var account = new Account
                            {
                                ID = rowObj.ID,
                                Email = rowObj.Email,
                                FullName = rowObj.FullName,
                                PhoneNumber = rowObj.PhoneNumber,
                                Address = rowObj.Address,
                                Role = rowObj.Role
                            };

                            if (accountController.Update(account))
                            {
                                MessageBox.Show($"Đã cập nhật user với ID {account.ID}");
                                this.accountTableAdapter.Fill(this.coffeChainManagementDBDataSet2.Account);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công.");
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
    

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
