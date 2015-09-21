namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PostalService : AbstractPostalService
    {
        private readonly Dictionary<string, Client> clients =
            new Dictionary<string, Client>();

        public override void Register(Client client)
        {
            if (!this.clients.ContainsValue(client))
            {
                this.clients[client.Name] = client;
            }

            client.PostalService = this;
        }

        public override void Send(string from, string to, string message)
        {
            var client = this.clients[to];

            if (client != null)
            {
                client.Receive(from, message);
            }
        }
    }
}
