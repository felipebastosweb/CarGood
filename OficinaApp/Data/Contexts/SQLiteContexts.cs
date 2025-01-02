using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OficinaApp.Data.Models;

namespace OficinaApp.Data.Contexts
{
    public partial class SQLiteContexts : IAsyncDisposable
    {
        public const string DatabaseFilename = "database.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

        SQLiteAsyncConnection? Database;

        public SQLiteContexts()
        {
        }

        public async Task Init()
        {
            if (Database is not null)
                return;
            Database = new SQLiteAsyncConnection(DatabasePath, Flags);
            await InitAuthorization();
            await InitLocalization();
            await InitSupplying();
        }

        public async ValueTask DisposeAsync()
        {
            await Database!.CloseAsync();
            Database = null;
            GC.SuppressFinalize(this);
        }

    }
}
