using MeuCarroApp.Shared.Components.Authentication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Crm.Interfaces
{
    public interface INewCustomerPublisher
    {
        public void Attach(INewCustomerSubscriber subscriber);
        public void Detach(INewCustomerSubscriber subscriber);
        public void Notify();
    }
    public interface INewCustomerSubscriber
    {
        void Update(ICustomer customer);
    }

}
