namespace Phonebook.Converts
{
    using System;

    public interface IConvertable
    {
        string ConvertPhoneNumber(string num);
    }
}
