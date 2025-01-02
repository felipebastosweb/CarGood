using MeuCarroApp.Shared.Components.Core.Contexts;
using MeuCarroApp.Shared.Components.Core.Entities;
using MeuCarroApp.Shared.Components.Accounts.Interfaces;
using MeuCarroApp.Shared.Components.Accounts.Records;


namespace MeuCarroApp.Shared.Components.Accounts.Repositories
{
    public class UserSQLiteRepository(SQLiteContexts context) : IUserRepository
    {
        public SQLiteContexts Context { get; set; } = context;

        public async Task<SignUpOutput?> SignUp(SignUpInput input)
        {
            var user = new User()
            { 
                Username = input.Username,
                PasswordHash = input.Password,
                CreatedAt = DateTime.UtcNow,
                KeepConnected = false
            };
            int rows = await Context!.Database!.InsertAsync(user);
            if (rows < 1)
            {
                throw new Exception("Falha na inscriçao do usuário.");
            }
            return new SignUpOutput()
            {
                Username = user.Username
            };
        }

        public Task<UserCreateOutput?> Insert(UserCreateInput input)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserQuickAccess>> UserQuickAccess()
        {
            await Context!.Init();
            var users = await Context!.Database!.Table<User>()
                .Where(user => user.KeepConnected == true)
                .ToListAsync();
            // Data Mapper
            var output = new List<UserQuickAccess>();
            foreach (var user in users)
            { 
                output.Add(
                    new UserQuickAccess() {
                        Username = user!.Username!,
                        // TODO : Create user access token
                        TokenAccess = string.Empty
                    }
                );
            }
            return output;
        }

        public Task<LoginOutput?> Login(LoginInput input)
        {
            throw new NotImplementedException();
        }

    }
}
