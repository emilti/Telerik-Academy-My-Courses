namespace Phonebook.Factories
{
    using Phonebook.Commands;     
    using Phonebook.Converts;
    using Phonebook.Print;

    public class RegularCommandsFactory : AbstractCommandsFactory
    {
         public RegularCommandsFactory(IConvertable converter, IPhonebookRepository repository, IPrintable printer) : base(converter, repository, printer)
        {
         }

        public override CommandAdd MakeCommandAdd()
        {
            return new CommandAdd(this.Converter, this.Repository, this.Printer);
        }

        public override CommandChange MakeCommandChange()
        {
            return new CommandChange(this.Converter, this.Repository, this.Printer);
        }

        public override CommandList MakeCommandList()
        {
            return new CommandList(this.Converter, this.Repository, this.Printer);
        }

        public override CommandRemove MakeCommandRemove()
        {
            return new CommandRemove(this.Converter, this.Repository, this.Printer);
        }
    }
}
