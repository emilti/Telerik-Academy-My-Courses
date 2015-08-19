namespace Point
{
    using System;

    public struct Point3D
    {
        // P2
        private static readonly Point3D Center = new Point3D() { PointX = 0, PointY = 0, PointZ = 0 }; 

        // P1
        private double pointX;
        private double pointY;
        private double pointZ;  

        // P2
        static Point3D()
        {
            Center = new Point3D(0, 0, 0);
        }

        // P1
        public Point3D(
            double inputX,
            double inputY, 
            double inputZ)
            : this()
        {
            this.PointX = inputX;
            this.PointY = inputY;
            this.PointZ = inputZ;
        }

        // P2
        // public static Point3D(double x=0,double y=0,double z=0)
        // {
        //     o.PointX = x;
        //     o.PointY = y;
        //     o.PointZ = z;
        // }
           
        // public int PointX { get; set; }
        // public int PointY { get; set; }
        // public int PointZ { get; set; }
        public static Point3D O
        {
            get
            {
                return Center;
            }
        }

        public double PointX
        {
            get
            {
                return this.pointX;
            }

            set
            {
                this.pointX = value;
            }
        }

        public double PointY
        {
            get
            {
                return this.pointY;
            }

            set
            {
                this.pointY = value;
            }
        }

        public double PointZ
        {
            get
            {
                return this.pointZ;
            }

            set
            {
                this.pointZ = value;
            }
        }        

        public override string ToString()
        {
            return string.Format(
                "X: {0}\n" +
                "Y: {1}\n" +
                "Z: {2}",
                this.PointX.ToString(), 
                this.PointY.ToString(),
                this.PointZ.ToString());
        }        
    }
}