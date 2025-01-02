

namespace OficinaApp.Data.Models
{
    public class Customer : BaseAuditableEntity
    {
        public Person? Person { get; set; }
        public Address? BillingAddress { get; set; }
        public DateTime CreationDate { get; set; }
    }

}
