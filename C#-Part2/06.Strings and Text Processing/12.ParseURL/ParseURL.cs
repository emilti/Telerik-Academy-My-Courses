using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParseURL
{
    public static void Main()
    {
        string text = Console.ReadLine();
        var url = new Uri(text);
         Console.WriteLine("[protocol]={0}", url.Scheme);
         Console.WriteLine("[server]={0}", url.Host);
         Console.WriteLine("[resource]={0}", url.AbsolutePath);
    }
}