using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if ANDROID
using SQLite;
#elif IOS
using SQLite;
#endif

namespace OficinaApp.Data.Models
{
    public partial class Manufacturer : BaseAuditableEntity
    {
        public string? Title { get; set; }
        public string? Site { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
    }

    public partial class Manufacturer : BaseAuditableEntity
    {
#if ANDROID || IOS
        [Ignore]
#endif
        public List<Brand>? Brands { get; set; }
    }

    public partial class Brand : BaseAuditableEntity
    {
        public Manufacturer? Manufacturer { get; set; }
        public required string Title { get; set; }
    }


    public partial class Brand : BaseAuditableEntity
    {
#if ANDROID || IOS
        [Ignore]
#endif
        public List<VehicleModel>? Models { get; set; }

    }

    public class VehicleModel : BaseAuditableEntity
    {
        public Brand? Brand { get; set; }
        public required string Title { get; set; }
#if ANDROID || IOS
        [Ignore]
#endif
        public virtual List<Vehicle>? Vehicles { get; set; }
    }

    public class Vehicle : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int ModelId { get; set; }
        public VehicleModel? Model { get; set; }
        public string? PlateNumber { get; set; }
        public int CustomerId { get; set; }
        public Customer? Owner { get; set; }
        public string? NameOfResponsible { get; set; }
        public int YearOfManufacture { get; set; }
        public int YearOfPurchase { get; set; }
    }

    /***
     * Ford - https://lista.mercadolivre.com.br/acessorios-veiculos/pecas-carros-caminhonetes/suspensao-direcao/amortecedores/amortecedor-motorcraft_Loja_ford_NoIndex_True
     * Ford - https://lista.mercadolivre.com.br/acessorios-veiculos/rodas/carros_Loja_ford_NoIndex_True
     * Ford - https://lista.mercadolivre.com.br/acessorios-veiculos/pecas-carros-caminhonetes/motor/motor-completo
     * Ford - https://www.reparadorford.com.br/motorcraft/linha-de-produtos/oleo
     * Diversas Marcas - https://www.allpartsnet.com.br/todos-produtos/motorcraft
     * 
     ***/

    public class AccessoryBrand
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Site { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
    }

    public class Accessory
    {
        public int Id { get; set; }
        public int AccessoryBrandId { get; set; }
        public AccessoryBrand? AccessoryBrand { get; set; }
        public string? Model { get; set; }
        public string? Content { get; set; }
    }



}
