using System;
using System.Collections.Generic;
using Garage.Interfaces;

namespace Garage
{
    public class BatteryStation : IStation<IElectricVehicle>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IElectricVehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.ChargeBattery();
            }
        }
    }
}