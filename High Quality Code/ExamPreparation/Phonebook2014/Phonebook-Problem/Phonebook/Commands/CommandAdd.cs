namespace Phonebook.Commands
{    
    using System.Linq;
    using Phonebook.Converts;
    using Phonebook.Print;

    public class CommandAdd : Command 
    {
        public CommandAdd(IConvertable converter, IPhonebookRepository repository, IPrintable printer)
            : base(converter, repository, printer)
        {         
        }
       
        public override void Execute(string[] inputData)
        {
            string name = inputData[0];
            var phoneNumbers = inputData.Skip(1).ToList();
            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                phoneNumbers[i] = this.Converter.ConvertPhoneNumber(phoneNumbers[i]);
            }

            bool isInPhonebook = PhonebookRepository.AddPhone(name, phoneNumbers);
            if (isInPhonebook)
            {
                Printer.Print("Phone entry merged"); 
            }
            else
            {
                Printer.Print("Phone entry created");                
            }
        }
    }
}
