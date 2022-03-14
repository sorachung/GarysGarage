using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls at you. Rruuuuuuummmmmble!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram gently rolls to a stop.");
        }
    }
}