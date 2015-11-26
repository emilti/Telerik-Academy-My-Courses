namespace FriendsOfPesho
{
    using System;

    public class Node : IComparable
    {
        public Node(int id)
        {
            this.ID = id;
            this.IsHosital = false;
        }

        public int ID { get; set; }

        public long DijkstraDistance { get; set; }

        public bool IsHosital { get; set; }

        public int CompareTo(object obj)
        {
            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }
}
