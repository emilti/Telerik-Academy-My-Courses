namespace LinearDataStructures
{
    /// <summary>
    /// Class for the items in the list.
    /// </summary>
    /// <typeparam name="T">Abstract data type</typeparam>
    public class ListItem<T>
    {
        public ListItem()
        {            
        }

        public ListItem(T inputValue)
        {
            this.Value = inputValue;
        }

        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
