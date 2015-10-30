namespace LinearDataStructures
{
    /// <summary>
    /// Linked List class
    /// </summary>
    /// <typeparam name="T">Abstract data type</typeparam>
    public class LinkedList<T>
    {
        public LinkedList()
        {
            this.FirstElement = new ListItem<T>();
        }

        public ListItem<T> FirstElement { get; set; }
    }
}
