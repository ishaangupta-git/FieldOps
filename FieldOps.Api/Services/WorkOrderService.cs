using FieldOps.Api.Models;
using FieldOps.Api.Repositories;

namespace FieldOps.Api.Services
{
    public class WorkOrderService
    {
        public readonly WorkOrderRepository _repository;
        public WorkOrderService(WorkOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<WorkOrder>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
