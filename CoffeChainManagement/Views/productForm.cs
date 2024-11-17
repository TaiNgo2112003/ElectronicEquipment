using CoffeChainManagement.Controller;
using CoffeChainManagement.Db;
using CoffeChainManagement.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoffeChainManagement
{
    public partial class productForm : Form
    {
        private ProductController productController;
        private string connectionString = DbConnection_.DbConfig.ConnectionString;
        public productForm()
        {
            InitializeComponent();
            productController = new ProductController(); // Khởi tạo controller
        }

        private void productForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSetProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.coffeChainManagementDBDataSetProduct.Product);
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSetCategory.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.coffeChainManagementDBDataSetCategory.Category);
            this.shopsTableAdapter.Fill(this.coffeChainManagementDBDataSet.Shops);
            this.supplierTableAdapter.Fill(this.coffeChainManagementDBDataSetSupplier.Supplier);
            this.categoryTableAdapter.Fill(this.coffeChainManagementDBDataSet15.Category);
            this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBox1.SelectedValue;
            LoadProducts(selectedCategoryId);
        }

        private void LoadProducts(int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE CategoryId = @CategoryId", connection);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                Product newProduct = new Product
                {
                    ProductName = tbPorductName.Text,
                    SupplierId = Convert.ToInt32(cbSupplier.SelectedValue),
                    UnitPrice = int.Parse(tbUnitPrice.Text),
                    Package = tbPackage.Text,
                    IsDiscontinued = checkIsContinue.Checked,
                    Stock = Convert.ToInt32(tbStock.Text),
                    ShopID = Convert.ToInt32(cbShop.SelectedValue),
                    CategoryId = Convert.ToInt32(cbCategory.SelectedValue)
                };

                // Gọi hàm từ Controller để thêm sản phẩm
                if (productController.Save(newProduct))
                {
                    MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product); // Làm mới danh sách sản phẩm
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin của sản phẩm này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowView = ((DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet14.ProductRow;
                        if (rowView != null)
                        {
                            int id = rowView.Id;
                            string productName = rowView.ProductName;
                            int supplierID = rowView.SupplierId;
                            int unitPrice = rowView.UnitPrice;  
                            string package = rowView.Package;   
                            bool Isdis = rowView.IsDiscontinued;
                            int stock = rowView.Stock;
                            int shopID = rowView.ShopID;
                            int categoryID = rowView.CategoryId;



                            Product productToUpdate = new Product
                            {
                                Id = id,
                                ProductName = productName,
                                SupplierId = supplierID,
                                UnitPrice = unitPrice,  
                                Package = package,  
                                IsDiscontinued = Isdis,
                                Stock = stock,
                                ShopID = shopID,    
                                CategoryId = categoryID,    
                                //Id = rowView.Id,
                                //ProductName = tbPorductName.Text,
                                //SupplierId = (int)cbSupplier.SelectedValue,
                                //UnitPrice = (int)unitPrice, // Giá đã được kiểm tra hợp lệ
                                //Package = tbPackage.Text,
                                //IsDiscontinued = checkIsContinue.Checked,
                                //Stock = stockValue, // Tồn kho đã được kiểm tra hợp lệ
                                //ShopID = (int)cbShop.SelectedValue,
                                //CategoryId = (int)cbCategory.SelectedValue
                            };

                            // Gọi phương thức Update từ controller để cập nhật sản phẩm
                            bool success = productController.Update(productToUpdate);
                            if (success)
                            {
                                MessageBox.Show("Đã cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product); // Làm mới danh sách sản phẩm
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowView = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet14.ProductRow;
                        if (rowView != null)
                        {
                            Product productToDelete = new Product { Id = rowView.Id };
                            bool success = productController.Delete(productToDelete);
                            if (success)
                            {
                                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product); // Làm mới danh sách sản phẩm
                            }
                            else
                            {
                                MessageBox.Show("Xóa sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                panel1.Visible = true;
            }else
            {
                panel1.Visible=false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowView = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet14.ProductRow;
                        if (rowView != null)
                        {
                            Product productToDelete = new Product { Id = rowView.Id };
                            bool success = productController.Delete(productToDelete);
                            if (success)
                            {
                                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product); // Làm mới danh sách sản phẩm
                            }
                            else
                            {
                                MessageBox.Show("Xóa sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin của sản phẩm này?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowView = ((DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet14.ProductRow;
                        if (rowView != null)
                        {
                            int id = rowView.Id;
                            string productName = rowView.ProductName;
                            int supplierID = rowView.SupplierId;
                            int unitPrice = rowView.UnitPrice;
                            string package = rowView.Package;
                            bool Isdis = rowView.IsDiscontinued;
                            int stock = rowView.Stock;
                            int shopID = rowView.ShopID;
                            int categoryID = rowView.CategoryId;



                            Product productToUpdate = new Product
                            {
                                Id = id,
                                ProductName = productName,
                                SupplierId = supplierID,
                                UnitPrice = unitPrice,
                                Package = package,
                                IsDiscontinued = Isdis,
                                Stock = stock,
                                ShopID = shopID,
                                CategoryId = categoryID,
                                //Id = rowView.Id,
                                //ProductName = tbPorductName.Text,
                                //SupplierId = (int)cbSupplier.SelectedValue,
                                //UnitPrice = (int)unitPrice, // Giá đã được kiểm tra hợp lệ
                                //Package = tbPackage.Text,
                                //IsDiscontinued = checkIsContinue.Checked,
                                //Stock = stockValue, // Tồn kho đã được kiểm tra hợp lệ
                                //ShopID = (int)cbShop.SelectedValue,
                                //CategoryId = (int)cbCategory.SelectedValue
                            };

                            // Gọi phương thức Update từ controller để cập nhật sản phẩm
                            bool success = productController.Update(productToUpdate);
                            if (success)
                            {
                                MessageBox.Show("Đã cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product); // Làm mới danh sách sản phẩm
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                Product newProduct = new Product
                {
                    ProductName = tbPorductName.Text,
                    SupplierId = Convert.ToInt32(cbSupplier.SelectedValue),
                    UnitPrice = int.Parse(tbUnitPrice.Text),
                    Package = tbPackage.Text,
                    IsDiscontinued = checkIsContinue.Checked,
                    Stock = Convert.ToInt32(tbStock.Text),
                    ShopID = Convert.ToInt32(cbShop.SelectedValue),
                    CategoryId = Convert.ToInt32(cbCategory.SelectedValue)
                };

                // Gọi hàm từ Controller để thêm sản phẩm
                if (productController.Save(newProduct))
                {
                    MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this.coffeChainManagementDBDataSet14.Product); // Làm mới danh sách sản phẩm
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
