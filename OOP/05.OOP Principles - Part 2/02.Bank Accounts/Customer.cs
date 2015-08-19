namespace Accounts
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }

            private set 
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value; 
                this.name = value;
            }
        }        
    }
}
