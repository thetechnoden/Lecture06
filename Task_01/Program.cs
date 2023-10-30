using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = new TransportNetwork();

            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.MoveVehicles();

            Route route = new Route("Lviv", "Kyiv");
            network.CalculateOptimalRoute(route, car);
        }
    }
}
