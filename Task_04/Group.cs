using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void Add(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public override void Draw()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }

        public override void Scale(float factor)
        {
            foreach (var primitive in primitives)
            {
                primitive.Scale(factor);
            }
        }
    }
}
