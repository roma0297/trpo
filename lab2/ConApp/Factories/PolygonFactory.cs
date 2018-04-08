using System;
using System.Collections.Generic;
using Shapes;
namespace ConApp.Factories
{
   internal abstract class PolygonFactory
    {
        public abstract Polygon CreatePolygon(params int[] values);
    }

    internal class RectangleFactory : PolygonFactory
    {
        public override Polygon CreatePolygon(params int[] values)
        {
            return new Rectangle(values[0], values[1], values[2], values[3]);
        }
    }

    internal class SquareFactory : RectangleFactory
    {
        public override Polygon CreatePolygon(params int[] values)
        {
            return new Square(values[0], values[1], values[2], values[3]);
        }
    }

    internal class PentagonFactory : PolygonFactory
    {
        public override Polygon CreatePolygon(params int[] values)
        {
            return new Pentagon(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
        }
    }
}

