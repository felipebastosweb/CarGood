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
        async Task InitSupplying()
        {
            await Database!.CreateTableAsync<Supplier>();
        }
    }
}
