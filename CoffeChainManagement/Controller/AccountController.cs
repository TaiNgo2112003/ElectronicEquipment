using CoffeChainManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.Data.SqlClient;
using CoffeChainManagement.Db;

namespace CoffeChainManagement.Controller
{
    internal class AccountController : IController<Account>
    {
        public static string connectionString = DbConnection_.DbConfig.ConnectionString;

        public bool Save(Account entity)
        {
            try
            {
                string hashedPassword = HashPassword(entity.Password);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Account (Username, Password, Email, FullName, PhoneNumber, Address, Role) " +
                                   "VALUES (@Username, @Password, @Email, @FullName, @PhoneNumber, @Address, @Role)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", entity.Username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Email", entity.Email);
                    command.Parameters.AddWithValue("@FullName", entity.FullName);
                    command.Parameters.AddWithValue("@PhoneNumber", entity.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", entity.Address);
                    command.Parameters.AddWithValue("@Role", entity.Role);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool Delete(Account entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Account WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", entity.ID);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool isValidate(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Account 
                                 SET Email = @Email, FullName = @FullName, 
                                     PhoneNumber = @PhoneNumber, Address = @Address, Role = @Role 
                                 WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", entity.ID);
                command.Parameters.AddWithValue("@Email", entity.Email);
                command.Parameters.AddWithValue("@FullName", entity.FullName);
                command.Parameters.AddWithValue("@PhoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("@Address", entity.Address);
                command.Parameters.AddWithValue("@Role", entity.Role);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
