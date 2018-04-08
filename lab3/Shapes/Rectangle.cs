using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Rectangle: Polygon
    {

        public Rectangle(int x1, int y1, int x2, int y2):base()
        {
            Location point1 = new Location();
            point1.X = x1;
            point1.Y = y1;

            Location point2 = new Location();
            point2.X = x2;
            point2.Y = y2;

            Location point3 = new Location();
            point3.X = x1;
            point3.Y = y2;

            Location point4 = new Location();
            point4.X = x2;
            point4.Y = y1;

            points = new List<Location>() { point1, point3, point2, point4 };
        }

        public Rectangle(Location point1, Location point2) : base()
        {
            Location point3 = new Location();
            point3.X = point1.X;
            point3.Y = point2.Y;

            Location point4 = new Location();
            point4.X = point2.X;
            point4.Y = point1.Y;

            points = new List<Location>(){point1, point2, point3, point4};
        }

        public override void Show()
        {
            Console.WriteLine("Class: Rectangle | Vertecies: ({0},{1}), ({2},{3}), ({4},{5}), ({6},{7})", points[0].X, points[0].Y, points[1].X, points[1].Y, points[2].X, points[2].Y, points[3].X, points[3].Y);
        }
    }

}
