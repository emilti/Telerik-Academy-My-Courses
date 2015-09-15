namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RealImage : Image
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }


        public void display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}