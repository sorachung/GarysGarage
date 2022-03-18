using System;
using System.Collections.Generic;

namespace Garage.Interfaces
{
    public interface IStation<T>
    {
        int Capacity { get; set; }
        void Refuel(List<T> vehicles);
    }
}