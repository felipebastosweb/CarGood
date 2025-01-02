using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuCarroApp.Shared.Components.Vehicles.Interfaces;

namespace MeuCarroApp.Shared.Components.Vehicles.Events
{
    /***
     * TODO: User Story - As a User, I want to be informed about the creation of my Account
     *                      so that I can use it.
     *       Scenary: I fill and submit the Sign Up Form
     *          Where I open the app for the first time
     *          And I fill the form fields
     *          And I click in Confirm's button
     *          Then the user is registered
     *          And the app open the Login page with a confirm subscription message
     *          And a Email with a message and token is received for me into e-mail account
     ***/


    public class NewVehiclePublisher : INewVehiclePublisher
    {
        public List<INewVehicleSubscriber> _subscribers = new();
        public void Attach(INewVehicleSubscriber subscriber)
        {
            throw new NotImplementedException();
        }
        public void Detach(INewVehicleSubscriber subscriber)
        {
            throw new NotImplementedException();
        }
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class PushNotificationNewVehicleSubscriber : INewVehicleSubscriber
    {
        public void Update(IVehicle Vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
