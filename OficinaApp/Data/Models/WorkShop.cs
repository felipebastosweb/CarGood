using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Models
{
    public interface IWorkShop { }

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
