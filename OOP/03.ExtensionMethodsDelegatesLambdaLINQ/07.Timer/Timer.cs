namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Timer
    {       
        public Timer(int t, Action<string> delegateMethod)
        {
            this.T = t;
            this.MyMethod = delegateMethod;
        }

        public int T { get; private set; }

        public Action<string> MyMethod { get; private set; }

        public static void DelegateMethod(string input)
        {
            Console.WriteLine(input);
        }
    }
}