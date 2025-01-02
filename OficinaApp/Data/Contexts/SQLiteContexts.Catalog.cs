using OficinaApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Contexts
{
    public partial class SQLiteContexts
    {
        async Task InitCatalog()
        {
            await Database!.CreateTableAsync<Product>();
            await Database!.CreateTableAsync<ProductContent>();
            await Database!.CreateTableAsync<ProductPrice>();
            //await Database!.CreateTableAsync<Product>();
            //await Database!.CreateTableAsync<Product>();
        }
    }
}
