using MeuCarroApp.Shared.Components.Core.Entities;

namespace MeuCarroApp.Shared.Components.Crm.Models
{
    public class Customer : BaseAuditableEntity
    {
        public Person? Person { get; set; }
        public Address? BillingAddress { get; set; }
        public DateTime CreationDate { get; set; }
    }

}
