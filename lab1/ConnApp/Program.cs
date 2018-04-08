using Shapes;
using System;

namespace ConnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon polygon = new Pentagon(0, 0, 2, 0, 2, 2, 1, 3, 0, 2);
            polygon.Show();
            Console.Write(polygon.GetArea());

            polygon = new Rectangle(0, 0, 4, 6);
            polygon.Show();
            Console.Write(polygon.GetArea());

            polygon = new Square(0, 0, 4, 4);
            polygon.Show();
            Console.Write(polygon.GetArea());
        }
    }
}
