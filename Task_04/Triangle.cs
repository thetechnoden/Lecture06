using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Triangle : GraphicPrimitive
    {
        public int SideLength { get; set; }

        public Triangle(int x, int y, int sideLength)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a triangle at ({X}, {Y}) with side length {SideLength}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            SideLength = (int)(SideLength * factor);
        }
    }
}
