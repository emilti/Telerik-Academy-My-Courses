namespace Phonebook.Commands
{
    using Phonebook.Converts;
    using Phonebook.Print;

    public class CommandChange : Command
    {
        public CommandChange(IConvertable converter, IPhonebookRepository repository, IPrintable printer) : base(converter, repository, printer)
        {         
        }

        public override void Execute(string[] inputData)
        {
            int convertedPhone = this.PhonebookRepository.ChangePhone(
                Converter.ConvertPhoneNumber(inputData[0]), 
                Converter.ConvertPhoneNumber(inputData[1]));
            Printer.Print(string.Empty + convertedPhone + " numbers changed");
        }
    }
}
