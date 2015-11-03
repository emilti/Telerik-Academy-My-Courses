namespace TreeTraverse
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T Value) : this()
        {
            this.Value = Value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
