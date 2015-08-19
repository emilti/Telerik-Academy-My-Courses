namespace Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {        
        private int size;
        private int numberOfColors;

        public Display(int screenSize, int screenColors)
        {            
            this.Size = screenSize;
            this.NumberOfColors = screenColors;
        }

        // P5
        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value > 40 || value < 0)
                {
                    throw new ArgumentException("Invalid size!");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value > 20000 || value < 0)
                {
                    throw new ArgumentException("Invalid number of colors!");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Size: {0}\n" +
                "Number of colors: {1}\n",
                this.Size, 
                this.NumberOfColors);
        }
    }
}