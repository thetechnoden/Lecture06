using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Rectangle : GraphicPrimitive
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle at ({X}, {Y}) with width {Width} and height {Height}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Width = (int)(Width * factor);
            Height = (int)(Height * factor);
        }
    }

}
