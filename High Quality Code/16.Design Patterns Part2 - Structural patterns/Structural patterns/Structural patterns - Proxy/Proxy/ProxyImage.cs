namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProxyImage : Image
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}

