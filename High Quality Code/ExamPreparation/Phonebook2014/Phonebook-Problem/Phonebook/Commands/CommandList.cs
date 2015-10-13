namespace Phonebook.Commands
{
    using System;
    using System.Collections.Generic;
    using Phonebook.Converts;
    using Phonebook.Print;

    public class CommandList : Command
    {
        public CommandList(IConvertable converter, IPhonebookRepository repository, IPrintable printer)
            : base(converter, repository, printer)
        {         
        }

        public override void Execute(string[] inputData)
        {
            try
            {
                IEnumerable<PersonRecord> entries = this.PhonebookRepository.ListEntries(int.Parse(inputData[0]), int.Parse(inputData[1]));
                foreach (var entry in entries)
                {
                    Printer.Print(entry.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Printer.Print("Invalid range");
            }
        }
    }
}
