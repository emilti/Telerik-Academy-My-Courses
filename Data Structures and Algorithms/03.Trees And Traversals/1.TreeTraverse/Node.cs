namespace TreeTraverse
{
    using System.Collections.Generic;

    public class Node<T>
    { 
        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value) : this()
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
