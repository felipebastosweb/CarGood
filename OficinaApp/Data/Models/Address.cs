using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Models
{
    public class Country : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public List<Zone>? Zones { get; set; }
    }
    public class Zone : BaseAuditableEntity
    {
        public Country? Country { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public List<ZoneChild>? Children { get; set; }
    }

    public class ZoneChild : BaseAuditableEntity
    {
        public int ZoneId { get; set; }
        public Zone? Zone { get; set; }
    }

    public class Address : BaseAuditableEntity
    {
        public string? Address1 { get; set; }
        public string? Number { get; set; }
        public string? Address2 { get; set; }
        public int ZoneId { get; set; }
        public Zone? Zone {  get; set; }
    }

    public class Contact
    {
        public string? Telephone { get; set; }
        public string? Email { get; set; }
    }

    public class LegalContact : Contact
    {
        public string? Site { get; set; }
        public string? Fax { get; set; }
    }
}
