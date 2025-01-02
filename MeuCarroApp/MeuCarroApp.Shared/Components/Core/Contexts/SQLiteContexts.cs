using SQLite;

namespace MeuCarroApp.Shared.Components.Core.Contexts
{
    public partial class SQLiteContexts : BaseContext<SQLiteAsyncConnection>
    {
        public const string DatabaseFilename = "database.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath => Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            DatabaseFilename);

        public SQLiteAsyncConnection? Database;

        public SQLiteContexts()
        {
        }

        public override async Task Init()
        {
            if (Database is not null)
                return;
            Database = new SQLiteAsyncConnection(DatabasePath, Flags);
            await InitAuthorization();
            await InitLocalization();
            await InitSupplying();
        }

        public override SQLiteAsyncConnection GetDatabase()
        { 
            return Database!;
        }
    }
}
