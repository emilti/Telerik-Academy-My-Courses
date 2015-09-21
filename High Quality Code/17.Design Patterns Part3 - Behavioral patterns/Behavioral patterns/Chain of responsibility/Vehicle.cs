namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal abstract class Vehicle
    {
        protected Vehicle Successor { get; set; }

        public void SetSuccessor(Vehicle successor)
        {
            this.Successor = successor;
        }

        public abstract void RequestToTransport(Bagage bagage);        
    }
}