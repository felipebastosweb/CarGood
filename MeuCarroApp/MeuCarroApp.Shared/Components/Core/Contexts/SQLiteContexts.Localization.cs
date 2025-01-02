using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuCarroApp.Shared.Components.Core.Entities;

namespace MeuCarroApp.Shared.Components.Core.Contexts
{
    public partial class SQLiteContexts
    {
        public async Task InitLocalization()
        {
            await Database!.CreateTableAsync<Country>();
            await Database!.CreateTableAsync<Language>();
            await Database!.CreateTableAsync<Zone>();
            await Database!.CreateTableAsync<ZoneChild>();
            await Database!.CreateTableAsync<Address>();
        }
    }
}
