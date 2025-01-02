using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OficinaApp.Data.Models;

namespace OficinaApp.Data.Events.NewWorkShop
{
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

    public class NewWorkShopPublisher : INewWorkShopPublisher
    {
        private IWorkShop? WorkShop { get; set; }
        private IList<INewWorkShopSubscriber>? _newWorkShopSubscribers { get; set; } = new List<INewWorkShopSubscriber>();
        
        public void Attach(INewWorkShopSubscriber subscriber)
        {
            _newWorkShopSubscribers!.Add(subscriber);
        }

        public void Detach(INewWorkShopSubscriber subscriber)
        {
            _newWorkShopSubscribers!.Remove(subscriber);
        }

        public IWorkShop SaveTheWorkShop(IWorkShop workshop)
        {
            // TODO: chamar operações para salvar Workshop no banco de dados
            WorkShop = workshop;
            if (WorkShop != null)
                Notify();
            return WorkShop!;
        }

        public void Notify()
        {
            // TODO: para melhorar o desempenho da aplicação chamar Threads (implementar paralelismo)
            foreach(var subscriber in _newWorkShopSubscribers!)
            {
                subscriber.Update(WorkShop!);
            }
        }
    }

    public class PushNotificationAboutNewWorkShopSubscriber : INewWorkShopSubscriber
    {
        /***
         * Add Push Notify or Pollover informing about the new workshop
         * https://learn.microsoft.com/en-us/dotnet/maui/data-cloud/push-notifications?view=net-maui-8.0
         * **/
        public void Update(IWorkShop workShop)
        {
            // TODO: 
        }
    }

    public class NotifyTheServerAboutTheNewWorkShopSubscriber : INewWorkShopSubscriber
    {
        /***
         * Send a Http request to Server informing about the new WorkShop
         * **/
        public void Update(IWorkShop workShop) {
            // TODO: Verify if App is connected in Internet
            // TODO: Send the request if connected
            // TODO: Update WokShop as NotNotifiedToServer if not connected in Internet
        }
    }

    public class EmailToOwnerAboutNewWorkShopSubscriber : INewWorkShopSubscriber
    {
        /***
         * Send a Email to Owner informing about the new WorkShop
         * **/
        public void Update(IWorkShop workShop)
        {
            // TODO: Verify if App is connected in Internet
            // TODO: Send the Email if connected
            // TODO: Update WorkShop as NotNotifiedByEmail if not connected in Internet
        }
    }


}
