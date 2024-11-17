using CoffeChainManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Controller
{
    internal class ProductController : BaseController, IController<Product>
    {
        public bool Save(Product entity)
        {
            bool success = false;

            using (SqlConnection connection = GetDbConnection())
            {
                connection.Open();
                string query = "INSERT INTO Product (ProductName, SupplierId, UnitPrice, Package, IsDiscontinued, Stock, ShopID, CategoryId) " +
                               "VALUES (@ProductName, @SupplierId, @UnitPrice, @Package, @IsDiscontinued, @Stock, @ShopID, @CategoryId)";
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm các tham số cho câu lệnh SQL
                command.Parameters.AddWithValue("@ProductName", entity.ProductName);
                command.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                command.Parameters.AddWithValue("@UnitPrice", entity.UnitPrice);
                command.Parameters.AddWithValue("@Package", entity.Package);
                command.Parameters.AddWithValue("@IsDiscontinued", entity.IsDiscontinued);
                command.Parameters.AddWithValue("@Stock", entity.Stock);
                command.Parameters.AddWithValue("@ShopID", entity.ShopID);
                command.Parameters.AddWithValue("@CategoryId", entity.CategoryId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }

            return success;
        }

        public bool Update(Product entity)
        {
            bool success = false;

            using (SqlConnection connection = GetDbConnection())
            {
                connection.Open();
                string query = "UPDATE Product SET ProductName = @ProductName, SupplierId = @SupplierId, UnitPrice = @UnitPrice, " +
                               "Package = @Package, IsDiscontinued = @IsDiscontinued, Stock = @Stock, ShopID = @ShopID, CategoryId = @CategoryId " +
                               "WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm các tham số cho câu lệnh SQL
                command.Parameters.AddWithValue("@ProductName", entity.ProductName);
                command.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                command.Parameters.AddWithValue("@UnitPrice", entity.UnitPrice);
                command.Parameters.AddWithValue("@Package", entity.Package);
                command.Parameters.AddWithValue("@IsDiscontinued", entity.IsDiscontinued);
                command.Parameters.AddWithValue("@Stock", entity.Stock);
                command.Parameters.AddWithValue("@ShopID", entity.ShopID);
                command.Parameters.AddWithValue("@CategoryId", entity.CategoryId);
                command.Parameters.AddWithValue("@Id", entity.Id);  // Thêm tham số ID

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }

            return success;
        }

        public bool Delete(Product entity)
        {
            bool success = false;

            using (SqlConnection connection = GetDbConnection())
            {
                connection.Open();
                string query = "DELETE FROM Product WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", entity.Id);

                // Thực thi truy vấn
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true; // Ít nhất một dòng bị ảnh hưởng, tức là dữ liệu đã được xóa
                }
            }

            return success;
        }

        public bool isValidate(Product entity)
        {
            // Kiểm tra tính hợp lệ của sản phẩm (có thể thêm logic kiểm tra tại đây)
            return !string.IsNullOrEmpty(entity.ProductName) && entity.UnitPrice >= 0;
        }
    }
}
