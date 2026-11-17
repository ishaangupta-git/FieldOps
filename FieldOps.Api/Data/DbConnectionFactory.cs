using Microsoft.Data.SqlClient;

namespace FieldOps.Api.Data
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;
        public DbConnectionFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string not found.");
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
