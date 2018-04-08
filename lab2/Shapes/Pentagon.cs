using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Pentagon : Polygon
    {

        public Pentagon(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5) : base()
        {
            Location point1 = new Location();
            point1.X = x1;
            point1.Y = y1;
            Location point2 = new Location();
            point2.X = x2;
            point2.Y = y2;
            Location point3 = new Location();
            point3.X = x3;
            point3.Y = y3;
            Location point4 = new Location();
            point4.X = x4;
            point4.Y = y4;
            Location point5 = new Location();
            point5.X = x5;
            point5.Y = y5;

            points = new List<Location> {point1, point2, point3, point4, point5};
        }

        public Pentagon(Location point1, Location point2, Location point3, Location point4, Location point5) : base(new List<Location>() { point1, point2, point3, point4, point5 })
        {}

        public override void Show()
        {
            Console.WriteLine("Class: Pentagon | Vertecies: ({0},{1}), ({2},{3}), ({4},{5}), ({6},{7}), ({8},{9})", points[0].X, points[0].Y, points[1].X, points[1].Y, points[2].X, points[2].Y, points[3].X, points[3].Y, points[4].X, points[4].Y);
        }
    }
}
