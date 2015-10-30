namespace LinearDataStructures
{
    using System;
    /// <summary>
    /// Implement the ADT stack as auto-resizable array.
    /// Resize the capacity on demand 
    /// (when no space is available to add / insert a new element).
    /// </summary>
    public class MainProgram
    {
        public static void Main()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);  
            Console.WriteLine(string.Join(", ", myStack.Array));                         
        }
    }
}
