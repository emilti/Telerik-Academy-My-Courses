namespace Recursion
{
    using System.Collections.Generic;

    public class Index
    {
        public Index()
        {
            this.Children = new List<Index>();
        }

        public int Value { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public List<Index> Children { get; set; }
    }
}