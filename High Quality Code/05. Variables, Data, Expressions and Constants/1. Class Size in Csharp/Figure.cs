namespace Rotation
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
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

            private set
            {
                ValidateIfPositive(value);
                this.height = value;
            }
        }

        public Figure GetRotatedSize(double angleOfRotation)
        {
            var absoluteCosAngle = Math.Abs(Math.Cos(angleOfRotation));
            var absoluteSinAngle = Math.Abs(Math.Sin(angleOfRotation));

            var figureWidthAfterRotation = (absoluteCosAngle * this.Width) + (absoluteSinAngle * this.Height);
            var figureHeightAfterRotation = (absoluteSinAngle * this.Width) + (absoluteCosAngle * this.Height);
            Figure rotatedFigure = new Figure(figureWidthAfterRotation, figureHeightAfterRotation);
            return rotatedFigure;
        }

        private static void ValidateIfPositive(double value)
        {
            if (value < 0)
            {
                throw new Exception("Value can not be negative");
            }
        }
    }
}
