using System.Data.SqlClient;
using CoffeChainManagement.Db;

namespace CoffeChainManagement.Controller
{
    public class BaseController : DbConnection_
    {
        protected SqlConnection GetDbConnection()
        {
            return GetConnection();     
        }
    }
}
