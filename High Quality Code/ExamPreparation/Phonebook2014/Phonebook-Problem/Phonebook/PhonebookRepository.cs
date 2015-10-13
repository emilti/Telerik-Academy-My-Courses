namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class PhonebookRepository : IPhonebookRepository
    {       
        private List<PersonRecord> records = new List<PersonRecord>();
        
        public bool AddPhone(string name, IEnumerable<string> nums)
        {
            var old = from e in this.records
                      where e.Name.ToLowerInvariant() == name.ToLowerInvariant()
                      select e;

            bool isInPhonebook;          
            if (old.Count() == 0)
            {
                PersonRecord personRecord = new PersonRecord();
                personRecord.Name = name;   

                foreach (var num in nums)
                {
                    personRecord.PhoneNumbers.Add(num);
                }

                this.records.Add(personRecord);
                isInPhonebook = false;
            }
            else if (old.Count() == 1)
            {
                PersonRecord existingPersonRecord = old.First();
                foreach (var num in nums)
                {
                    existingPersonRecord.PhoneNumbers.Add(num);
                }

                isInPhonebook = true;
            }
            else
            {
                Console.WriteLine("Duplicated name in the phonebook found: " + name);
                return false;
            }

            return isInPhonebook;
        }

        public int ChangePhone(string oldNumber, string newNumber)
        {
            var list = from e in this.records
                       where e.PhoneNumbers.Contains(oldNumber)
                       select e;
            int nums = 0;

            foreach (var entry in list)
            {
                entry.PhoneNumbers.Remove(oldNumber);
                entry.PhoneNumbers.Add(newNumber);
                nums++;
            }

            return nums;
        }

        public PersonRecord[] ListEntries(int start, int num)
        {
            if (start < 0 || start + num > this.records.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or count.");
            }

            this.records.Sort();
            PersonRecord[] ent = new PersonRecord[num];
            for (int i = start; i <= start + num - 1; i++)
            {
                PersonRecord entry = this.records[i];
                ent[i - start] = entry;
            }

            return ent;
        }

        public bool RemovePhone(string name, string numberForRemoving)
        {
            var list = from e in this.records
                       where e.PhoneNumbers.Contains(numberForRemoving)
                       select e;

            var personInPhonebook = from e in this.records
                      where e.Name.ToLowerInvariant() == name.ToLowerInvariant()
                      select e;
            bool isInPhonebook = false;
            if (personInPhonebook.Count() == 0)
            {
                return isInPhonebook; 
            }
            else
            {
                foreach (var entry in list)
                {
                    entry.PhoneNumbers.Remove(numberForRemoving);   
                }

                return isInPhonebook = true;
            }
        }
    }
}
