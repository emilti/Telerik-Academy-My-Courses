namespace ToStringConverter
{
    using System;

    public class StartProgram
    {
        private const int MAXCOUNT = 6;    
    
        public static void Main()
        {
            StringPrinter currentString = new StringPrinter();
            currentString.Stringifier(true);
        }    
    }
}
