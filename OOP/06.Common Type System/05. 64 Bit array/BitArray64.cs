namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        private int[] numberAsArray = new int[64];

        public BitArray64(ulong inputNumber)
        {
            this.Number = inputNumber;
        }

        public ulong Number
        {
            get 
            {
                return this.number;
            }

            private set
            {
                this.number = value;
            }
        }                

        public int this[int index]
        {
            get
            {
                int tmp;

                if (index >= 0 && index <= 63)
                {
                    return (int)((this.number >> index) & 1);                    
                }
                else
                {
                    throw new Exception("Index oit of range");
                }

                return tmp;
            }

            set
            {
                if (index >= 0 && index <= 64)
                {
                    this.numberAsArray[index] = value;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }     

        public IEnumerator<int> GetEnumerator()
        {
            string binary = string.Empty;
            ulong numberForConversion = this.Number;
            while (numberForConversion > 0)
            {
                ulong res = numberForConversion % 2;
                binary = res + binary;
                numberForConversion = numberForConversion / 2;
            }

            for (int i = 0; i < binary.Length; i++)
            {
                ulong mask = (ulong)(1 << i);
                ulong nAndMask = this.number & mask;
                ulong bit = nAndMask >> i;
                yield return (int)bit;
            }
        }

        public override bool Equals(object b)
        {
            var c = b as BitArray64;
            if (c is BitArray64)
            {
                return c.Number == this.Number;
            }
            else
            {
                throw new Exception("b is not BitArray64");
            }
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            if (!(a is BitArray64) && (b is BitArray64))
            {
                throw new ArgumentException("Passed object is not BitArray64.");
            }

            if (a.Number == b.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            if (!(a is BitArray64) && (b is BitArray64))
            {
                throw new ArgumentException("Passed object is not BitArray64.");
            }

            if (a.Number != b.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   

        public override string ToString()
        {
            string binary = string.Empty;
            ulong numberForConversion = this.Number;
            while (numberForConversion > 0)
            {
                ulong res = numberForConversion % 2;
                binary = res + binary;
                numberForConversion = numberForConversion / 2;
            }

            return binary;
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }
    }
}
