using Microsoft.AspNetCore.Mvc;
using FieldOps.Api.Services;

namespace FieldOps.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkOrdersController: ControllerBase
    {
        private readonly WorkOrderService _workOrderService;
        public WorkOrdersController(WorkOrderService workOrderService)
        {
            _workOrderService = workOrderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkOrders()
        {
            var workOrders = await _workOrderService.GetAllAsync();
            // Implementation for retrieving work orders
            return Ok(workOrders);
        }

        [HttpGet("{customerId:int}")]
        public async Task<IActionResult> GetByCustomerIdAsync(int customerId) 
        {
            var workOrders =  await _workOrderService.GetByCustomerIdAsync(customerId);
            return Ok(workOrders);
        }
    }
}
