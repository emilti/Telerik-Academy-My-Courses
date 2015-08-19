namespace Shape
{
    using System;
    using System.Collections.Generic;

    public class ShapeTest
    {
        public static void Main()
        {
            var shapes = new Shape[]
            { 
                new Rectangle(3, 2),
                new Triangle(3, 3),
                new Square(3)
            };

            foreach (var figure in shapes)
            {
                Console.WriteLine("The figure is {0} and its surface is {1}", figure.ToString(), figure.CalculateSurface());
            }
        }
    }
}