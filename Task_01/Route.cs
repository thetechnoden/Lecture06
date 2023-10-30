using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        public Route(string start, string end)
        {
            StartPoint = start;
            EndPoint = end;
        }
    }
}
