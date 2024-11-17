using CoffeChainManagement.Db;
using CoffeChainManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Controller
{

    public static class globaldb
    {
        public static string connectionString = DbConnection_.DbConfig.ConnectionString;
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static void Execute(Action<SqlConnection> action)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                action(connection);
            }
        }
    }

    internal class EmployeeController : BaseController, IController<Models.Employee_>
    {

        public bool Delete(Models.Employee_ entity)
        {
            bool success = false;
            globaldb.Execute((c) =>
            {
                string query = "DELETE FROM Employee WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@Id", entity.Id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            });

            return success;
        }

        public bool isValidate(Models.Employee_ entity)
        {
            return true;
        }

        public bool Save(Models.Employee_ entity) //3 cái 1.Pham vi: public, protected, private, 2.Kiểu:int,, 3. tên, 
        {
            bool success = false;

            // Validation logic before saving
            if (!isValidate(entity))
            {
                return false; // Invalid entity, so don't proceed with saving
            }
            globaldb.Execute((c) =>
            {
                string query = "INSERT INTO Employee (FullName, Email, Phone, ShopID, Position, HireDate) " +
                       "VALUES (@FullName, @Email, @Phone, @ShopID, @Position, @HireDate)";
                SqlCommand command = new SqlCommand(query, c);

                // Adding parameters to prevent SQL injection
                command.Parameters.AddWithValue("@FullName", entity.FullName);
                command.Parameters.AddWithValue("@Email", entity.Email);
                command.Parameters.AddWithValue("@Phone", entity.Phone);
                command.Parameters.AddWithValue("@ShopID", entity.ShopID);
                command.Parameters.AddWithValue("@Position", entity.Position);
                command.Parameters.AddWithValue("@HireDate", entity.HireDate);

                // Execute the query
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true; // Successfully inserted the record
                }
            });

            return success;
        }

        public bool Update(Models.Employee_ entity)
        {
            bool success = false;
            globaldb.Execute((c) =>
            {
                string query = "UPDATE Employee SET FullName = @FullName, Email = @Email, Phone = @Phone, ShopID = @ShopID, Position = @Position, HireDate = @HireDate WHERE Id = @ID";
                SqlCommand command = new SqlCommand(query);

                command.Parameters.AddWithValue("@FullName", entity.FullName);
                command.Parameters.AddWithValue("@Email", entity.Email);
                command.Parameters.AddWithValue("@Phone", entity.Phone);
                command.Parameters.AddWithValue("@ShopID", entity.ShopID);
                command.Parameters.AddWithValue("@Position", entity.Position);
                command.Parameters.AddWithValue("@HireDate", entity.HireDate);
                command.Parameters.AddWithValue("@ID", entity.Id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            });
               
            return success;
        }
    }
}
