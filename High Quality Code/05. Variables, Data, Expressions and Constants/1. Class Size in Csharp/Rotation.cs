namespace Rotation
{
    using System;

    public class Rotation
    {
        public static void Main()
        {
            Figure newFigure = new Figure(3, 4);
            Figure rotatedFigure = newFigure.GetRotatedSize(30);
        }  
    }
}