using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MeuCarroApp.Shared.Components.WorkShops.Interfaces
{
    public interface IWorkShop { }
    public interface INewWorkShopPublisher
    {
        public void Attach(INewWorkShopSubscriber workShop);
        public void Detach(INewWorkShopSubscriber workShop);
        public void Notify();
    }

    public interface INewWorkShopSubscriber
    {
        void Update(IWorkShop workshop);
    }
}
