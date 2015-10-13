namespace Phonebook
{
    using System.Collections.Generic;
    using Phonebook;
    
    public interface IPhonebookRepository
    {
        /// <summary>
        /// Adding phone to the phonebook database
        /// </summary>
        /// <param name="name">input string for the name of the recorded person the phonebook</param>
        /// <param name="phoneNumbers">The phonenumbers of the recorded person</param>
        /// <returns>returns whether thje phone number that is added was part of the phonebook or not</returns>
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);
        
        /// <summary>
        /// Changing phonenumbers in the phonebook
        /// </summary>
        /// <param name="oldPhoneNumber">Old phone number</param>
        /// <param name="newPhoneNumber">New Phone number</param>
        /// <returns>returns the number of changed phone numbers</returns>
        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        /// <summary>
        /// Remove phone number from the phonebook
        /// </summary>
        /// <param name="name">Input name of the recorded person which number will be removed</param>
        /// <param name="phoneForRemoving">The phone which will be removed</param>
        /// <returns>Returns bool value whether the removing was successful or not.</returns>
        bool RemovePhone(string name, string phoneForRemoving);

        PersonRecord[] ListEntries(int startIndex, int count);
    }
}
