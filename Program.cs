using System;
using System.Collections.Generic;
using Garage.Interfaces;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue",
                MaximumOccupancy = 2,
                BatteryKWh = 7.2,
                CurrentChargePercentage = 50

            };

            Zero fx = new Zero()
            {
                MainColor = "Midnight Black",
                MaximumOccupancy = 2,
                BatteryKWh = 7.2,
                CurrentChargePercentage = 75

            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Burgundy",
                MaximumOccupancy = 5,
                BatteryKWh = 100,
                CurrentChargePercentage = 24

            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 2,
                FuelCapacity = 25
            };

            Ram ram1500 = new Ram()
            {
                MainColor = "Silver",
                MaximumOccupancy = 5,
                FuelCapacity = 26
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            ram1500.Drive();
            ram1500.Turn("right");
            ram1500.Stop();



        }
    }
}