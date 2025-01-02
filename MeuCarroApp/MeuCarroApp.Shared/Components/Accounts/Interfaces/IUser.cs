using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Authentication.Interfaces
{
    public interface IUser
    {
    }

    public interface IRole
    {
    }


    public interface IPermission
    {
    }

    public interface ISignUpPublisher
    {
        void Attach(ISignUpSubscriber subscriber);
        void Detach(ISignUpSubscriber subscriber);
        void Notify();
    }

    public interface ISignUpSubscriber
    {
        void Update(IUser user);
    }


}
