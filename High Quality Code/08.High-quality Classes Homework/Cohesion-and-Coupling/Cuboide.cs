namespace CohesionAndCoupling
{
    using System;

    public class Cuboide
    {
        private double width;
        private double height;
        private double depth;

        public Cuboide(double width, double height, double depth) 
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get 
            {
                return this.width;
            }

            set 
            {
                ValidateIfPositive(value);
                this.width = value;
            }
        }              

        public double Height
        {
            get 
            {
                return this.height; 
            }

            set 
            {
                ValidateIfPositive(value);
                this.height = value;
            }
        }       

        public double Depth
        {
            get 
            {
                return this.depth; 
            }

            set 
            {
                ValidateIfPositive(value);
                this.depth = value;
            }
        }   

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = Distance.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = Distance.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = Distance.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = Distance.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        private static void ValidateIfPositive(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Value should be positive.");
            }
        }
    }
}
