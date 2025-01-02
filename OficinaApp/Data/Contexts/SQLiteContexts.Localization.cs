using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OficinaApp.Data.Models;

namespace OficinaApp.Data.Contexts
{
    public partial class SQLiteContexts
    {
        async Task InitLocalization()
        {
            await Database!.CreateTableAsync<Country>();
            await Database!.CreateTableAsync<Zone>();
            await Database!.CreateTableAsync<ZoneChild>();
            await Database!.CreateTableAsync<Address>();
        }
    }
}
