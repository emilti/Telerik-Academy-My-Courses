namespace ToStringConverter
{
    using System;

    public class StringPrinter
    {
        public void Stringifier(bool inputVariable)
        {
            string inputVariableAsString = inputVariable.ToString();
            Console.WriteLine(inputVariableAsString);
        }
    }
}