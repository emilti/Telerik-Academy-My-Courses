namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Bagage
    {
        public Bagage(int weight)
        {
            this.Weight = weight;           
        }      

        public double Weight { get; set; }
    }
}
