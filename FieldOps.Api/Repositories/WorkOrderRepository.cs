using Dapper;
using FieldOps.Api.Data;
using FieldOps.Api.Models;

namespace FieldOps.Api.Repositories
{
    public class WorkOrderRepository
    {
        private readonly DbConnectionFactory _connectionFactory;
        public WorkOrderRepository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<WorkOrder>> GetAllAsync()
        {
            const string sql = @"SELECT WorkOrderId, CustomerId, Title, Status, CreatedDate FROM dbo.WorkOrders;";

            using var connection  = _connectionFactory.CreateConnection();

            var workOrders = await connection.QueryAsync<WorkOrder>(sql);

            return workOrders;
        }
    }
}
