using CoffeChainManagement.Models;
using System;
using System.Data.SqlClient;

namespace CoffeChainManagement.Controller
{
    internal class StoreController : BaseController, IController<Shops>
    {
        public bool isValidate(Shops shops)
        {
            return true;   
        }
        public bool Save(Shops shop)
        {
            bool success = false;

            using (SqlConnection connection = GetDbConnection())
            {
                connection.Open();
                string query = "INSERT INTO Shops (ShopName, Address, PhoneNumber, OpeningHours, Revenue, ImagePath, Description) " +
                               "VALUES (@ShopName, @Address, @PhoneNumber, @OpeningHours, @Revenue, @ImagePath, @Description)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShopName", shop.ShopName);
                command.Parameters.AddWithValue("@Address", shop.Address);
                command.Parameters.AddWithValue("@PhoneNumber", shop.PhoneNumber);
                command.Parameters.AddWithValue("@OpeningHours", shop.OpeningHours);
                command.Parameters.AddWithValue("@Revenue", shop.Revenue);
                command.Parameters.AddWithValue("@ImagePath", shop.ImagePath);
                command.Parameters.AddWithValue("@Description", shop.Description);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
            }
            return success;
        }

        public bool Update(Shops shop)
        {
            bool success = false;

            using (SqlConnection connection = GetDbConnection())
            {
                connection.Open();
                string query = "UPDATE Shops SET ShopName = @ShopName, Address = @Address, PhoneNumber = @PhoneNumber, " +
                               "OpeningHours = @OpeningHours, Revenue = @Revenue, ImagePath = @ImagePath, Description = @Description " +
                               "WHERE ShopID = @ShopID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShopID", shop.ShopID);
                command.Parameters.AddWithValue("@ShopName", shop.ShopName);
                command.Parameters.AddWithValue("@Address", shop.Address);
                command.Parameters.AddWithValue("@PhoneNumber", shop.PhoneNumber);
                command.Parameters.AddWithValue("@OpeningHours", shop.OpeningHours);
                command.Parameters.AddWithValue("@Revenue", shop.Revenue);
                command.Parameters.AddWithValue("@ImagePath", shop.ImagePath);
                command.Parameters.AddWithValue("@Description", shop.Description);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
            }
            return success;
        }

        public bool Delete(Shops shop)
        {
            bool success = false;

            using (SqlConnection connection = GetDbConnection())
            {
                connection.Open();
                string query = "DELETE FROM Shops WHERE ShopID = @ShopID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShopID", shop.ShopID);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
            }
            return success;
        }

    }
}
