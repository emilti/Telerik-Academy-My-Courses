﻿namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Truck : Vehicle
    {
        public override void RequestToTransport(Bagage bagage)
        {
            if (bagage.Weight < 1000)
            {
                Console.WriteLine("Bagage transported by " + this.ToString());
            }
            else if (this.Successor != null)
            {
                this.Successor.RequestToTransport(bagage);
            }
            else 
            {
                Console.WriteLine("Bagage can not be transported!");
            }
        }

        public override string ToString()
        {
            return "My Truck";
        }
    }
}
