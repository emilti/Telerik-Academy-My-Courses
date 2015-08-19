using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EncodeDecode
{
    public static void Main()
    {
        Console.WriteLine("Enter original text");
        string originalText = Console.ReadLine();
        Console.WriteLine("Enter cipher:");
        string cipher = Console.ReadLine();        
        char[] originalTextChars = originalText.ToCharArray();
        char[] cipherChars = cipher.ToCharArray();
        char[] encodedMessageChars = new char[originalText.Length];
        StringBuilder decodedMessageBuilder = MakeCoding(originalTextChars, cipherChars);       
        Console.WriteLine("Decoded message:");
        Console.WriteLine(decodedMessageBuilder.ToString());
        StringBuilder encodedMessageBuilder = MakeCoding(decodedMessageBuilder.ToString().ToCharArray(), cipherChars);
        Console.WriteLine("Encoded message:");
        Console.WriteLine(encodedMessageBuilder.ToString());  
    }

    public static StringBuilder MakeCoding(char[] code, char[] cipher)
    {
        StringBuilder messageBuilder = new StringBuilder();
        int rotationCount = 0;
        for (int i = 0; i < code.Length; i++)
        {
            int result = (code[i] - 65) ^ (cipher[i - (rotationCount * cipher.Length)] - 65);
            messageBuilder.Append((char)(result + 65));
            if (i == cipher.Length - 1)
            {
                rotationCount++;
            }
        }

        return messageBuilder;
    }
}