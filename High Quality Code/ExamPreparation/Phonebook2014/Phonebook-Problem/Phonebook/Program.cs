namespace Phonebook
{
    using System;
    using Phonebook.Commands;
    using Phonebook.Converts;
    using Phonebook.Factories; 
    using Phonebook.Print;     

    public class MainProgram
    { 
        public static void Main()
        {
            IPhonebookRepository phonebookRepository = new PhonebookRepository();
            IConvertable convertPhoneNumber = new Converter();
            IPrintable printer = new Printer();
            AbstractCommandsFactory factory = new RegularCommandsFactory(convertPhoneNumber, phonebookRepository, printer);
            ICommand add = factory.MakeCommandAdd();
            ICommand change = factory.MakeCommandChange();
            ICommand list = factory.MakeCommandList();
            ICommand remove = factory.MakeCommandRemove();
            Processor processor = new Processor();
            processor.ProcessCommands(add, change, list, remove);
        }             
    }
}
