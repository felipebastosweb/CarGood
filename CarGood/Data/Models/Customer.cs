

namespace FelipeBastosWeb.Data.Models
{
    public enum Gender
    {
        Female,
        Male,
        Indeterminate
    }

    public class Customer : BaseModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public string BillingAddress { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
