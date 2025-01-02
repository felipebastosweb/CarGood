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
        
        async Task InitAuthorization()
        {
            await Database!.CreateTableAsync<User>();
            await Database!.CreateTableAsync<Role>();
        }
    }
}
