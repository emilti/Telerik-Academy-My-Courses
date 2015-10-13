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
       
        public override void Execute(string[] strings)
        {
            string str0 = strings[0];
            var str1 = strings.Skip(1).ToList();
            for (int i = 0; i < str1.Count; i++)
            {
                str1[i] = this.Converter.ConvertPhoneNumber(str1[i]);
            }

            bool flag = PhonebookRepository.AddPhone(str0, str1);
            if (flag)
            {
                 Printer.Print("Phone entry created");
            }
            else
            {
                Printer.Print("Phone entry merged");
            }
        }
    }
}
