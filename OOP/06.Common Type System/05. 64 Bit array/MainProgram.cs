namespace BitArray
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Console.WriteLine("Check for the enumerator:");
            BitArray64 num = new BitArray64(24);
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }

            BitArray64 num2 = new BitArray64(22);            
            Console.WriteLine("{0} {1}", num, num2);
            Console.WriteLine("Equals overriden:");
            Console.WriteLine(num.Equals(num2));
            Console.WriteLine("== overriden");
            Console.WriteLine(num == num2);
            Console.WriteLine("!= overriden");
            Console.WriteLine(num == num2);
            Console.WriteLine("Check for the index");
            Console.WriteLine("{0}", num[3]);
            Console.WriteLine(num.GetHashCode());
        }
    }
}