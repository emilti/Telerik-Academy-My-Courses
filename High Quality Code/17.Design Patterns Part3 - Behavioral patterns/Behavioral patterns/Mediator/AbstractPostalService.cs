namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class AbstractPostalService
    {
        public abstract void Register(Client client);

        public abstract void Send(string from, string to, string message);        
    }
}
