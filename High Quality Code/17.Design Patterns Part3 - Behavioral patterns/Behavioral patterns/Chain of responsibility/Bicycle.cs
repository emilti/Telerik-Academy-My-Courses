namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Bicycle : Vehicle
    {
        public override void RequestToTransport(Bagage bagage)
        {
            if (bagage.Weight < 10)
            {
                Console.WriteLine("Bagage transported by " + this.ToString());
            }
            else if (this.Successor != null)
            {
                this.Successor.RequestToTransport(bagage);
            }
        }

        public override string ToString()
        {
            return "My Bicycle";
        }
    }
}
