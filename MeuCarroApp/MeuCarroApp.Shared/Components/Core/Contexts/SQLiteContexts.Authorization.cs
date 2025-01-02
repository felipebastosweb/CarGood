using SQLite;
using MeuCarroApp.Shared.Components.Accounts.Records;
using MeuCarroApp.Shared.Components.Core.Services;
using MeuCarroApp.Shared.Components.Core.Entities;

namespace MeuCarroApp.Shared.Components.Core.Contexts
{
    public partial class SQLiteContexts
    {
        public CryptoService cryptoService { get; set; } = new();
        async Task InitAuthorization()
        {
            await Database!.CreateTableAsync<User>();
            await Database!.CreateTableAsync<UserTelephone>();
            await Database!.CreateTableAsync<UserEmail>();
            await Database!.CreateTableAsync<Role>();
            await Database!.CreateTableAsync<RolePermission>();
            await Database!.CreateTableAsync<Permission>();
        }

    }
}
