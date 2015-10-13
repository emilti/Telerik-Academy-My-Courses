namespace Phonebook
{
    using System;
    using Phonebook.Commands;
    using Phonebook.Converts;
    using Phonebook.Factories; 
    using Phonebook.Print;     

    public class Class2
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
