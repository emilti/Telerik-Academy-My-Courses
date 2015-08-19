namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class StringBuilderExtClass
    {
        public static StringBuilder Substring(this StringBuilder originalSB, int index, int length)
        {
            if (index < 0 || index + length > originalSB.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid length and index!");
            }

            StringBuilder resultSB = new StringBuilder();
            string result = string.Empty;
            result = originalSB.ToString().Substring(index, length);
            resultSB.Append(result);
            return resultSB;
        }      
    }
}