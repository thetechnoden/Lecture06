using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Circle : GraphicPrimitive
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle at ({X}, {Y}) with radius {Radius}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Radius = (int)(Radius * factor);
        }
    }

}
