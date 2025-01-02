using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuCarroApp.Shared.Components.Core.Enums;

namespace MeuCarroApp.Shared.Components.Core.Entities
{
    public abstract class Person
    {
        public string? Name { get; set; }
        public Contact? Contact { get; set; }
    }

    public class PhysicalPerson : Person
    {
        public string? SocialName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public IdentityCard? IDCard { get; set; } // Brazilian RG
        public SocialSecurity? SSN { get; set; } // Brazilian CPF
    }

    public partial class IdentityCard
    {
        public string? Numer { get; set; }
        public Zone? Zone { get; set; }
        public DateTime IssueDate { get; set; }
    }

    public partial class SocialSecurity
    {
        public string? Number { get; set; }
        public bool IsActive { get; set; }
    }

    public class LegalPerson : Person
    {
        public string? TradeName { get; set; }
        public string? FederalInscriptionNumber { get; set; }
        public DateTime StartDate { get; set; }
    }
}
