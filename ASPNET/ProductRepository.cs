using Dapper;
using System.Data;
using ASPNET.Models;

namespace ASPNET
{
    public class ProductRepository
    {
        private readonly IDbConnection _connection;
        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return (IEnumerable<Product>)_connection.Query("SELECT * FROM products;");
        }
    }
}
