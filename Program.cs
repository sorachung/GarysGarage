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

            Cessna cessna150 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 2,
                FuelCapacity = 25,
                CurrentTankPercentage = 50
            };

            Ram ram = new Ram()
            {
                MainColor = "Silver",
                MaximumOccupancy = 5,
                FuelCapacity = 26,
                CurrentTankPercentage = 60
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
             };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            cessna150.Drive();
            cessna150.Turn("right");
            cessna150.Stop();

            ram.Drive();
            ram.Turn("right");
            ram.Stop();



        }
    }
}