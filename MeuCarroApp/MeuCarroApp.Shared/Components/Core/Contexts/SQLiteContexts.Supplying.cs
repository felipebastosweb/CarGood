using MeuCarroApp.Shared.Components.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Core.Contexts
{
    public partial class SQLiteContexts
    {
        async Task InitSupplying()
        {
            await Database!.CreateTableAsync<Supplier>();
        }
    }
}
