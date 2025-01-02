using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Vehicles.Interfaces
{
    public interface IVehicle
    {

    }

    public interface INewVehiclePublisher
    {
        void Attach(INewVehicleSubscriber subscriber);
        void Detach(INewVehicleSubscriber subscriber);
        void Notify();
    }

    public interface INewVehicleSubscriber
    {
        void Update(IVehicle Vehicle);
    }


}
