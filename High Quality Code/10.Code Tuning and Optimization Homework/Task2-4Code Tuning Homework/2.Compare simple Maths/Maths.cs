namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Maths
    {
        // Test Addition, Subtraction, Incremention, Multiplication and Division with 5 types of data (int, long, float, double, decimal)
        public static void Main()
        {
            TestAdd.TestAddInt();
            TestAdd.TestAddLong();
            TestAdd.TestAddFloat();
            TestAdd.TestAddDouble();
            TestAdd.TestAddDecimal();

            TestSubtract.TestSubtractInt();
            TestSubtract.TestSubtractLong();
            TestSubtract.TestSubtractFloat();
            TestSubtract.TestSubtractDouble();
            TestSubtract.TestSubtractDecimal();

            TestIncrement.TestIncrementInt();
            TestIncrement.TestIncrementLong();
            TestIncrement.TestIncrementFloat();
            TestIncrement.TestIncrementDouble();
            TestIncrement.TestIncrementDecimal();

            TestMultiply.TestMultiplyInt();
            TestMultiply.TestMultiplyLong();
            TestMultiply.TestMultiplyFloat();
            TestMultiply.TestMultiplyDouble();
            TestMultiply.TestMultiplyDecimal();

            TestDivide.TestDivideInt();
            TestDivide.TestDivideLong();
            TestDivide.TestDivideFloat();
            TestDivide.TestDivideDouble();
            TestDivide.TestDivideDecimal();
        }
    }
}
