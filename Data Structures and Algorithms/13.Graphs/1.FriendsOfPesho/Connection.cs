namespace FriendsOfPesho
{
    public class Connection
    {  
        public Connection(Node toNode, long distance)
        {
            this.ToNode = toNode;
            this.Distance = distance;
        }

        public Node ToNode { get; set; }

        public long Distance { get; set; }
    }
}
