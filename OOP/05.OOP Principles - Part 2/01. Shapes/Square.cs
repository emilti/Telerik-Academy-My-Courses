namespace Shape
{
    public class Square : Shape, ISurface
    {
        public Square(double side)
            : base(side)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("Square");
        }
    }
}
