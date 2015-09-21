namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Client : AbstractClient
    {
        public Client(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {            
            base.Receive(from, message);
        }
    }
}
