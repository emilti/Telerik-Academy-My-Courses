﻿namespace Phonebook
{
    using System.Collections.Generic;
    using Phonebook;
    
    public interface IPhonebookRepository
    {
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        Class1[] ListEntries(int startIndex, int count);
    }
}
