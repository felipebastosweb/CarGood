using MeuCarroApp.Shared.Components.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Vehicles.Records
{

    public record VehicleInput
    {
        public Manufacturer? Manufacturer { get; set; }
        public Brand? Brand { get; set; }
        public VehicleModel? Model { get; set; }
        public string? Name { get; set; }
        public string? PlateNumber { get; set; }
    }


}