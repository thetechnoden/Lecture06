using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Train : Vehicle
    {
        public Train()
        {
            Speed = 100;
            Capacity = 100;
        }

        public override void Move()
        {
            Console.WriteLine("Train is moving.");
        }
    }
}
