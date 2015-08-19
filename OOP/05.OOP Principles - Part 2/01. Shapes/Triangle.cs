namespace Shape
{
    public class Triangle : Shape, ISurface
    {
        public Triangle(double width, double height) : base(width, height)
        {           
        }

        public override double CalculateSurface()
        {            
            double surface = this.Width * this.Height / 2;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("Triangle");
        }
    }
}
