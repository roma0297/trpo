using System;
using System.Collections.Generic;
using System.Linq;
using Shapes;

namespace Shapes
{
    public abstract class Polygon
    {
        protected const double EPSILON = 1E-6;
        protected List<Location> points;

        protected Polygon()
        {
        }

        protected Polygon(List<Location> points)
        {
            this.points = points;
        }

        public double GetArea(){
            return CalculateArea(); 
        }

        private double CalculateArea(){
            return Math.Abs(points.Take(points.Count - 1)
                            .Select((p, i) => (points[i + 1].X - p.X) * (points[i + 1].Y + p.Y))
                                   .Sum() / 2);   
        }

        public abstract void Show();

        public int CompareTo(object obj) {
            if (obj == null) {
                throw new ArgumentNullException();
            }

            var shape = obj as Shape;

            if (GetArea() < shape.GetArea())
                return -1;
            else if (GetArea() > shape.GetArea())
                return 1;
            else
                return 0;
            
        }
    }
}
