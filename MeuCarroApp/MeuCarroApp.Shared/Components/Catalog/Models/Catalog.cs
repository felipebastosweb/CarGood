using MeuCarroApp.Shared.Components.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Catalog.Moels
{
    public class WorkService : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }

    public class Product : BaseAuditableEntity
    {
        public string? Model { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductContent : BaseAuditableEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
    }

    // TODO? implementar preço por região
    /***
     * Como lojista desejo restringir a venda de produtos a determinadas regiões
     * **/
    public class ProductPriceByZone : BaseAuditableEntity
    {
        public decimal? Price { get; set; }
        public int ZoneId { get; set; }
        public Zone? Zone { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
