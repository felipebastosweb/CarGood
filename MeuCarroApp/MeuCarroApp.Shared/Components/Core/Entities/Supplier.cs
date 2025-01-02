using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Core.Entities
{
    public class Supplier : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? FantasyName { get; set; }
        public string? FederalRegistrationNumber { get; set; }
        public int AddressId { get; set; }
        [Ignore] public Address? Address { get; set; }
    }
}
