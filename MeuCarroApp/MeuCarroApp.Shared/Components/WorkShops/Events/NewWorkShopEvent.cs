using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MeuCarroApp.Shared.Components.Core.Entities;
using MeuCarroApp.Shared.Components.WorkShops.Interfaces;

namespace MeuCarroApp.Shared.Components.WorkShops.Events
{
    public class NewWorkShopPublisher : INewWorkShopPublisher
    {
        private IWorkShop? WorkShop { get; set; }
        private List<INewWorkShopSubscriber>? NewWorkShopSubscribers { get; set; }

        public NewWorkShopPublisher()
        {
            NewWorkShopSubscribers = new();
        }

        public void Attach(INewWorkShopSubscriber subscriber)
        {
            NewWorkShopSubscribers!.Add(subscriber);
        }

        public void Detach(INewWorkShopSubscriber subscriber)
        {
            NewWorkShopSubscribers!.Remove(subscriber);
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
            foreach (var subscriber in NewWorkShopSubscribers!)
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
            throw new NotImplementedException();
        }
    }

    public class NotifyTheServerAboutTheNewWorkShopSubscriber : INewWorkShopSubscriber
    {
        /***
         * Send a Http request to Server informing about the new WorkShop
         * **/
        public void Update(IWorkShop workShop)
        {
            // TODO: Verify if App is connected in Internet
            // TODO: Send the request if connected
            // TODO: Update WokShop as NotNotifiedToServer if not connected in Internet
            throw new NotImplementedException();
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
