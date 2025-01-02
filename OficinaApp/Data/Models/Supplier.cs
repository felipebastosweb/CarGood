using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Models
{
    public class Supplier : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? FantasyName { get; set; }
        public string? FederalRegistrationNumber { get; set; }
        public Address? Address { get; set; }
    }
}
