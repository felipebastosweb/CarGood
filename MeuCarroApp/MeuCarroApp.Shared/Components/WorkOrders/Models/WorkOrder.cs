using MeuCarroApp.Shared.Components.Catalog.Moels;
using MeuCarroApp.Shared.Components.Core.Entities;
using MeuCarroApp.Shared.Components.Crm.Models;
using MeuCarroApp.Shared.Components.Hrm.Models;
using MeuCarroApp.Shared.Components.Vehicles.Models;
using MeuCarroApp.Shared.Components.WorkShops.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.WorkOrders.Models
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
        public decimal? TotalServices { get; set; }
        public decimal? TotalProducts { get; set; }
        public decimal? Total
        {
            get
            {
                return TotalServices + TotalProducts;
            }
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<WorkOrderItem>? WorkOrderItems { get; set; }
        public WorkOrderStatus Status { get; set; }
    }


    public class WorkOrderItem : BaseAuditableEntity
    {
        public WorkOrder? Order { get; set; }
        public WorkService? Service { get; set; }
        public Product? Product { get; set; }
        public EmployeePosition? EmployeePosition { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
