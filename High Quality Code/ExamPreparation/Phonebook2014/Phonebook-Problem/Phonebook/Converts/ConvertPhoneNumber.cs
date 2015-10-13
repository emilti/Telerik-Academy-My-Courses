namespace Phonebook.Converts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Converter : IConvertable 
    {
        private const string Code = "+359";

        public string ConvertPhoneNumber(string num)
        {
            StringBuilder sb = new StringBuilder();

            sb.Clear();
            foreach (char ch in num)
            {
                if (char.IsDigit(ch) || (ch == '+'))
                {
                    sb.Append(ch);
                }
            }

            if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
            {
                sb.Remove(0, 1);
                sb[0] = '+';
            }

            while (sb.Length > 0 && sb[0] == '0')
            {
                sb.Remove(0, 1);
            }

            if (sb.Length > 0 && sb[0] != '+')
            {
                sb.Insert(0, Code);
            }

            return sb.ToString();
        }
    }
}
