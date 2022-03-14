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