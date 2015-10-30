namespace LinearDataStructures
{
   using System;

    /// <summary>
    /// Task 11. Implement the data structure linked list.
    ///     ○ Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>). 
    ///     ○ Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    /// </summary>
    public class MainProgram
    {
        public static void Main()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            var first = new ListItem<int>(2);
            var second = new ListItem<int>(222);
            first.NextItem = second;
            numbers.FirstElement = first;

            Console.WriteLine("First item in the list: {0}", numbers.FirstElement.Value);
            Console.WriteLine("Next item: {0}", first.NextItem.Value);
        }
    }
}
