using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public void CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            // Логіка розрахунку оптимального маршруту
            Console.WriteLine($"Optimal route {vehicle.GetType().Name} from {route.StartPoint} to {route.EndPoint}");
        }
    }

}
