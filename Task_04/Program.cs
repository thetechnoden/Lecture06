using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsEditor editor = new GraphicsEditor();

            Circle circle = new Circle(10, 10, 5);
            Rectangle rectangle = new Rectangle(20, 20, 8, 4);
            Triangle triangle = new Triangle(30, 30, 6);

            Group group = new Group();
            group.Add(circle);
            group.Add(rectangle);
            group.Add(triangle);

            editor.AddPrimitive(circle);
            editor.AddPrimitive(rectangle);
            editor.AddPrimitive(triangle);
            editor.AddPrimitive(group);

            editor.DrawAll();

            circle.Move(5, 5);
            group.Scale(1.5f);

            Console.WriteLine("After modifications:");
            editor.DrawAll();
        }
    }
}