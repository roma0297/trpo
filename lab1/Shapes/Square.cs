using System;
namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(Location point1, Location point2) : base(point1, point2)
        {
        }

        public Square(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Class: Square | Vertecies: ({0},{1}), ({2},{3}), ({4},{5}), ({6},{7})", points[0].X, points[0].Y, points[1].X, points[1].Y, points[2].X, points[2].Y, points[3].X, points[3].Y);
        }
    }
}
