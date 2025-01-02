using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuCarroApp.Shared.Components.Core.Entities;
using MeuCarroApp.Shared.Components.WorkShops.Interfaces;

namespace MeuCarroApp.Shared.Components.WorkShops.Models
{

    public class WorkShop : IWorkShop
    {
        public LegalPerson? LegalPerson {  get; set; }
        public PhysicalPerson? Owner {  get; set; }
        public string? Name { get; set; }
        public string? FantasyName { get; set; }
        public string? FederalRegistrationNumber { get; set; }
        public Address? Address { get; set; }
    }
}
