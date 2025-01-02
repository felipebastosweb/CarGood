using MeuCarroApp.Shared.Components.Accounts.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Accounts.Interfaces
{
    public interface IUserRepository
    {
        Task<SignUpOutput?> SignUp(SignUpInput input);
        Task<UserCreateOutput?> Insert(UserCreateInput input);
        Task<LoginOutput?> Login(LoginInput input);
        Task<List<UserQuickAccess>> UserQuickAccess();
    }
}
