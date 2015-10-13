namespace Phonebook.Factories
{
    using Phonebook.Commands;
    using Phonebook.Converts;
    using Phonebook.Print;

    public abstract class AbstractCommandsFactory
    {
        public AbstractCommandsFactory(IConvertable converter, IPhonebookRepository repository, IPrintable printer)
        {
            this.Converter = converter;
            this.Repository = repository;
            this.Printer = printer;
        }

        public IConvertable Converter { get; set; }

        public IPhonebookRepository Repository { get; set; }

        public IPrintable Printer { get; set; }

        public abstract CommandAdd MakeCommandAdd();

        public abstract CommandChange MakeCommandChange();

        public abstract CommandList MakeCommandList();

        public abstract CommandRemove MakeCommandRemove();
    }
}