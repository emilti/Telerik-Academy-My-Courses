namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PersonRecord : IComparable<PersonRecord>
    {        
        private string name; 
        private string name2;

        public PersonRecord()
        {
            this.PhoneNumbers = new SortedSet<string>();
        }

        public SortedSet<string> PhoneNumbers { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.name2 = value.ToLowerInvariant();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append('[');
            sb.Append(this.Name);
            bool flag = true;
            foreach (var phone in this.PhoneNumbers)
            {
                if (flag)
                {
                    sb.Append(": ");
                    flag = false;
                }
                else
                {
                    sb.Append(", ");
                }

                sb.Append(phone);
            }

            sb.Append(']');
            return sb.ToString();
        }

        public int CompareTo(PersonRecord other)
        {
            return this.name2.CompareTo(other.name2);
        }
    }
}
