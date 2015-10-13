namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Odbc;
    using System.Data.Sql;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Net.Sockets;
    using System.Text;
    using Phonebook.Commands;
    using Phonebook.Converts;    
    using Phonebook.Print;
    using Wintellect.PowerCollections;   

    public class Class2
    { 
        public static void Main()
        {
            IPhonebookRepository phonebookRepository = new PhonebookRepository();
            IConvertable convertPhoneNumber = new Converter();
            IPrintable printer = new Printer();
            ICommand add = new CommandAdd(convertPhoneNumber, phonebookRepository, printer);
            ICommand change = new CommandChange(convertPhoneNumber, phonebookRepository, printer);
            ICommand list = new CommandList(convertPhoneNumber, phonebookRepository, printer);
            ICommand remove = new CommandRemove(convertPhoneNumber, phonebookRepository, printer);
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "End" || data == null)
                {
                    // Error reading from console 
                    break;
                }

                int i = data.IndexOf('(');
                if (i == -1)
                {
                    Console.WriteLine("error!");
                    Environment.Exit(0);
                }

                string commandInput = data.Substring(0, i);
                if (!data.EndsWith(")"))
                {
                    Main();
                }

                string s = data.Substring(
                    i + 1,
                    data.Length - i - 2);
                string[] commandData = s.Split(',');
                for (int j = 0; j < commandData.Length; j++)
                {
                    commandData[j] = commandData[j].Trim();
                }

                if (commandInput.StartsWith("AddPhone") && (commandData.Length >= 2))
                {
                    add.Execute(commandData);
                }
                else if (commandInput.StartsWith("ChangePhone") && (commandData.Length == 2))
                {
                    change.Execute(commandData);
                }
                else if (commandInput.StartsWith("RemovePhone") && (commandData.Length == 2))
                {
                    remove.Execute(commandData);
                }
                else if ((commandInput == "List") && (commandData.Length == 2))
                {                    
                    list.Execute(commandData);
                }
                else
                {
                    continue;
                }
            }
        }       
    }
}
