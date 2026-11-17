namespace FieldOps.Api.Models
{
    public class WorkOrder
    {
        public int WorkOrderId { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
