namespace Phonebook.Print
{
    using System; 

    public class Printer : IPrintable
    {
        public void Print(string text)
        {
            // input.AppendLine(text);
            Console.WriteLine(text);
        }
    }
}
