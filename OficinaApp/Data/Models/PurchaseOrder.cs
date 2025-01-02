using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Models
{
    // Compra de peças
    public class Purchase : BaseAuditableEntity
    {
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public double? Total { get; set; }

    }

    public class PurchaseItem : BaseAuditableEntity
    {
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public double? Total { get; set; }
    }


    // Parceria com outros fornecedores (ex. Torneiro Mecânico)
    public class PurchaseOrder : BaseAuditableEntity
    {
        public Supplier? Supplier {  get; set; }
        public double? Total { get; set; }
        public List<PurchaseOrderItem>? PurchaseItems {  get; set; }
    }

    public class PurchaseOrderItem : BaseAuditableEntity
    {
        public PurchaseOrder? PurchaseOrder { get; set; }
        public Service? Service { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public double? Total { get; set; }
    }
}
