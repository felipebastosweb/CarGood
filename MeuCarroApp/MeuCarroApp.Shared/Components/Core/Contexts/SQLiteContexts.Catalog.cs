using MeuCarroApp.Shared.Components.Catalog.Moels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Core.Contexts
{
    public partial class SQLiteContexts
    {
        public async Task InitCatalog()
        {
            await Database!.CreateTableAsync<Product>();
            await Database!.CreateTableAsync<ProductContent>();
            await Database!.CreateTableAsync<ProductPriceByZone>();
            //await Database!.CreateTableAsync<Product>();
            //await Database!.CreateTableAsync<Product>();
        }
    }
}
