namespace Phonebook.Commands
{
    using Phonebook.Converts;
    using Phonebook.Print;

    public abstract class Command : ICommand
    {
        public Command(IConvertable converter, IPhonebookRepository repository, IPrintable printer)
        {
            this.Converter = converter;
            this.PhonebookRepository = repository;
            this.Printer = printer;
        }

        public IPhonebookRepository PhonebookRepository { get; set; }

        public IConvertable Converter { get; set; }

        public IPrintable Printer { get; set; }

        public abstract void Execute(string[] strings);        
    }
}
