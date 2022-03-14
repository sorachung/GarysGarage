using System;
using Garage.Interfaces;
namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} blazes by you. Bbbbbbrrrrrr!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla squeals around a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}