using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Car : Vehicle
    {
        public Car()
        {
            Speed = 60;
            Capacity = 5;
        }

        public override void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }
}
