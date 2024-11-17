using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Db
{
    public class DbConnection_
    {
        // Lớp chứa cấu hình kết nối
        public static class DbConfig
        {
            // Thuộc tính tĩnh để lấy ConnectionString
            public static string ConnectionString { get; } = "Server=TAIPC\\SQLSERVERM1;Database=CoffeChainManagementDB;User Id=sa;Password=123;";
        }

        // Phương thức trả về SqlConnection sử dụng ConnectionString từ DbConfig
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(DbConfig.ConnectionString);
        }
    }
}