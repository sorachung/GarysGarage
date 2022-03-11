using System;

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
                BatteryKWh = 7.2

            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Burgundy",
                MaximumOccupancy = 5,
                BatteryKWh = 100

            };
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
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();
        }
    }
}