using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Models
{
    public enum WorkOrderStatus { Ready = 0, Running = 1, Held = 2, Finished = 3, Canceled = -1 }

    // Orçamento, Ordem de Serviço
    public class WorkOrderType : BaseAuditableEntity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
    }

    public class WorkOrder : BaseAuditableEntity
    {
        public int WorkShopId { get; set; }
        public WorkShop? WorkShop { get; set; }
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string? Observation { get; set; }
        public double? TotalServices { get; set; }
        public double? TotalProducts { get; set; }
        public double? Total
        {
            get
            {
                return TotalServices + TotalProducts;
            }
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<WorkItem>? WorkItems { get; set; }
        public List<ServiceItem>? ServiceItems { get; set; }
        public WorkOrderStatus Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class WorkItem : BaseAuditableEntity
    {
        public WorkOrder? Order { get; set; }
        public Product? Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }

    public class ServiceItem : BaseAuditableEntity
    {
        public WorkOrder? Order { get; set; }
        public Service? Service { get; set; }
        public EmployeePosition? EmployeePosition { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }

    }
}
