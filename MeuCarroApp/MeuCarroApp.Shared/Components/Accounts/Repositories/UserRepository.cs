using MeuCarroApp.Shared.Components.Core.Contexts;
using MeuCarroApp.Shared.Components.Core.Entities;
using MeuCarroApp.Shared.Components.Accounts.Interfaces;
using MeuCarroApp.Shared.Components.Accounts.Records;
using MeuCarroApp.Shared.Components.Accounts.Services;



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
            await Context!.Init();
            int rows = await Context!.Database!.InsertAsync(user);
            if (rows < 1)
            {
                throw new Exception("Falha na inscriçao do usuário.");
            }
            // Validar formato do email
            var userEmail = new UserEmail()
            {
                UserId = user!.Id,
                Email = input.Email,
                IsMain = true
            };

            rows = await Context!.Database!.InsertAsync(userEmail);
            if (rows < 1)
            {
                throw new Exception("Falha na inserçao do E-mail do usuário.");
            }
            return new SignUpOutput()
            {
                Username = user.Username,
                Email = input.Email
            };
        }

        public async Task<UserCreateOutput?> Insert(UserCreateInput input)
        {
            var user = new User()
            {
                Username = input.Username,
                PasswordHash = input.Password,
                CreatedAt = DateTime.UtcNow,
                KeepConnected = false
            };
            await Context!.Init();
            int rows = await Context!.Database!.InsertAsync(user);

            if (rows < 1)
            {
                throw new Exception("Falha na inscriçao do usuário.");
            }
            // Validar formato do email
            var userEmail = new UserEmail()
            {
                UserId = user!.Id,
                Email = input.Email,
                IsMain = true
            };

            rows = await Context!.Database!.InsertAsync(userEmail);
            if (rows < 1)
            {
                throw new Exception("Falha na inserçao do E-mail do usuário.");
            }

            return new UserCreateOutput() { Username = user.Username};
        }

        public async Task<List<UserQuickAccess>> UserQuickAccess()
        {
            await Context!.Init();
            var users = await Context!.Database!.Table<User>()
                //.Where(user => user.KeepConnected == true)
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

        public async Task<LoginOutput?> Login(LoginInput input)
        {
            await Context!.Init();
            var user = await Context!.Database!.Table<User>()
                .Where(user => user.Username == input.Username)
                .FirstAsync();
            if (user.PasswordHash != input.Password)
            {
                return null;
                //throw new Exception("Tentativa de login falha");
            }

            // https://copilot.microsoft.com/chats/S1qwKk4GqZW4vNGyXAXDb
            // continuar
            return new LoginOutput()
            {
                Username = user!.Username!,
                KeepConnected = user!.KeepConnected
            };
        }

    }
}
