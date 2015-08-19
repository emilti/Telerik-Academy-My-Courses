namespace Shape
{
    public class Rectangle : Shape, ISurface
    {
        public Rectangle(double width, double height) : base(width, height)
        {           
        }

        public override double CalculateSurface()
        {            
            double surface = this.Width * this.Height;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("Rectangle");
        }
    }
}