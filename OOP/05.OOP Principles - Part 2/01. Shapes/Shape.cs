namespace Shape
{
    using System;  
    
    public abstract class Shape : ISurface
    {
        private double width;
        private double height;       

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double side)
        {
            this.Width = side;
            this.height = side;            
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid value");
                }

                this.width = value; 
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid value");
                }

                this.height = value;
            }
        }  
       
        public abstract double CalculateSurface();
    }
}
