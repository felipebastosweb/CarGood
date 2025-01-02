using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Suppliers.Records
{
    public record SupplierInput
    {
        public string? Name { get; set; }
        public string? FantasyName { get; set; }
        public string? FederalRegistrationNumber { get; set; }
    }
    public record SupplierOutput
    {
        public string? Name { get; set; }
        public string? FantasyName { get; set; }
        public string? FederalRegistrationNumber { get; set; }
    }
}
