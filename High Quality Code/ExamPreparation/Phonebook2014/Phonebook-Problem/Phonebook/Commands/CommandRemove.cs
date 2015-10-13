namespace Phonebook.Commands
{
    using System.Collections.Generic;
    using System.Linq;
    using Phonebook.Converts;
    using Phonebook.Print;    

    public class CommandRemove : Command
    {
        public CommandRemove(IConvertable converter, IPhonebookRepository repository, IPrintable printer)
            : base(converter, repository, printer)
        {         
        }       

        public override void Execute(string[] commandData)
        {
            string name = commandData[0];
            string phoneForRemoving = commandData[1];
            phoneForRemoving = this.Converter.ConvertPhoneNumber(phoneForRemoving);
            bool isRemoved = PhonebookRepository.RemovePhone(name, phoneForRemoving);
            if (isRemoved)
            {
                Printer.Print("Successfully removed");
            }
            else 
            {
                Printer.Print("Phone number could not be found");
            }
        }
    }
}
