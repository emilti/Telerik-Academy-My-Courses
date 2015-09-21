namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class AbstractClient
    {
        private readonly string name;
        private PostalService postalService;

        protected AbstractClient(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public PostalService PostalService
        {
            get 
            {
                return this.postalService; 
            }

            set 
            {
                this.postalService = value; 
            }
        }

        public void Send(string to, string message)
        {
            this.PostalService.Send(this.name, to, message);
        }       

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, this.Name, message);
        }
    }
}
