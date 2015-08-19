namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdvancedMaths
    {
        // Test Sqrt, Log and Sinus with three type of data (int, double and decimal)
        public static void Main()
        {
            TestSqrt.TestSqrtFloat();
            TestSqrt.TestSqrtDouble();
            TestSqrt.TestSqrtDecimal();

            TestLog.TestLogFloat();
            TestLog.TestLogDouble();
            TestLog.TestLogDecimal();

            TestSinus.TestSinusFloat();
            TestSinus.TestSinusDouble();
            TestSinus.TestSinusDecimal();
        }
    }
}
