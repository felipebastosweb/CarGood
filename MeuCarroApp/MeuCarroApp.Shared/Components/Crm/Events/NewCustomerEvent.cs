using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuCarroApp.Shared.Components.Crm.Interfaces;

namespace MeuCarroApp.Shared.Components.Crm.Events
{
    /***
     * TODO: User Story - As a WorkShop Owner, I want to add a new Customer to my WorkShop
     *                      so that I can manager your Service Orders and Orders.
     *       Scenary: I fill and submit the Sign Up Form
     *          Where I open the app for the first time
     *          And I fill the form fields
     *          And I click in Confirm's button
     *          Then the user is registered
     *          And the app open the Login page with a confirm subscription message
     *          And a Email with a message and token is received for me into e-mail account
     ***/


    public class NewCustomerPublisher : INewCustomerPublisher
    {
        public List<INewCustomerSubscriber> _subscribers = new();
        public void Attach(INewCustomerSubscriber subscriber)
        {
            throw new NotImplementedException();
        }
        public void Detach(INewCustomerSubscriber subscriber)
        {
            throw new NotImplementedException();
        }
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class PushNotificationNewCustomerSubscriber : INewCustomerSubscriber
    {
        public void Update(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}
