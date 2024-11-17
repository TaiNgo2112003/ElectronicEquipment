using CoffeChainManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoffeChainManagement.Controller
{
    internal class PromotionController : IController<Promotion>
    {
        // Xóa khuyến mãi
        public bool Delete(Promotion entity)
        {
            bool success = false;

            globaldb.Execute((connection) =>
            {
                string query = "DELETE FROM Promotion WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", entity.Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0; // Kiểm tra xem có dòng nào bị ảnh hưởng không
                }
            });

            return success;
        }

        // Lưu khuyến mãi
        public bool Save(Promotion entity)
        {
            bool success = false;

            globaldb.Execute((connection) =>
            {
                string query = "INSERT INTO Promotion (PromotionName, Discount, StartDate, EndDate) " +
                               "VALUES (@PromotionName, @Discount, @StartDate, @EndDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PromotionName", entity.PromotionName);
                    command.Parameters.AddWithValue("@Discount", entity.Discount);
                    command.Parameters.AddWithValue("@StartDate", entity.StartDate);
                    command.Parameters.AddWithValue("@EndDate", entity.EndDate);

                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0; // Kiểm tra xem có dòng nào bị ảnh hưởng không
                }
            });

            return success;
        }

        // Cập nhật khuyến mãi
        public bool Update(Promotion entity)
        {
            bool success = false;

            globaldb.Execute((connection) =>
            {
                string query = "UPDATE Promotion SET PromotionName = @PromotionName, Discount = @Discount, " +
                               "StartDate = @StartDate, EndDate = @EndDate WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", entity.Id);
                    command.Parameters.AddWithValue("@PromotionName", entity.PromotionName);
                    command.Parameters.AddWithValue("@Discount", entity.Discount);
                    command.Parameters.AddWithValue("@StartDate", entity.StartDate);
                    command.Parameters.AddWithValue("@EndDate", entity.EndDate);

                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0; // Kiểm tra xem có dòng nào bị ảnh hưởng không
                }
            });

            return success;
        }

        // Kiểm tra tính hợp lệ của khuyến mãi
        public bool isValidate(Promotion entity)
        {
            // Thêm logic kiểm tra tính hợp lệ cho khuyến mãi nếu cần
            return true;
        }
    }
}