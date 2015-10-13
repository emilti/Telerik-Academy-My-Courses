namespace Phonebook.Commands
{
    using System;
    using Phonebook.Converts;

    public interface ICommand
    {
        void Execute(string[] strings);
    }
}
