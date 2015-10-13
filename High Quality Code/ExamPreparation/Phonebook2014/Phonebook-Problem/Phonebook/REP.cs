namespace Phonebook
{
    using System;
    using System.Collections.Generic;   
    using System.Linq;
    using Wintellect.PowerCollections;

    public class REP : IPhonebookRepository
    {
        private OrderedSet<PersonRecord> sorted = new OrderedSet<PersonRecord>();
        private Dictionary<string, PersonRecord> dict = new Dictionary<string, PersonRecord>();
        private MultiDictionary<string, PersonRecord> multidict = new MultiDictionary<string, PersonRecord>(false);

        public bool AddPhone(string name, IEnumerable<string> nums)
        {
            string name2 = name.ToLowerInvariant();
            PersonRecord entry;
            bool flag = !this.dict.TryGetValue(name2, out entry);
            if (flag)
            {
                entry = new PersonRecord();
                entry.Name = name;
                entry.PhoneNumbers = new SortedSet<string>();
                this.dict.Add(name2, entry);
                this.sorted.Add(entry);
            }

            foreach (var num in nums)
            {
                this.multidict.Add(num, entry);
            }

            entry.PhoneNumbers.UnionWith(nums);
            return flag;
        }

        public int ChangePhone(string oldent, string newent)
        {
            var found = this.multidict[oldent].ToList();
            foreach (var entry in found)
            {
                entry.PhoneNumbers.Remove(oldent);
                this.multidict.Remove(oldent, entry);
                entry.PhoneNumbers.Add(newent);
                this.multidict.Add(newent, entry);
            }

            return found.Count;
        }

        public PersonRecord[] ListEntries(int first, int num)
        {
            if (first < 0 || first + num > this.dict.Count)
            {
                Console.WriteLine("Invalid start index or count.");
                return null;
            }

            PersonRecord[] list = new PersonRecord[num];
            for (int i = first; i <= first + num - 1; i++)
            {
                PersonRecord entry = this.sorted[i];
                list[i - first] = entry;
            }

            return list;
        }

        public bool RemovePhone(string name, string phoneForRemoving)
        {
            throw new NotImplementedException();
        }
    }
}
