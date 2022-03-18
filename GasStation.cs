using System;
using System.Collections.Generic;
using Garage.Interfaces;

namespace Garage
{
    public class GasStation : IStation<IGasVehicle>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGasVehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.RefuelTank();
            }
        }
    }
}