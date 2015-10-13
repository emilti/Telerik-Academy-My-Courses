﻿namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Odbc;
    using System.Data.Sql;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Net.Sockets;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Class2
    {
        private const string Code = "+359";
        private static IPhonebookRepository data = new REPNew();
        private static StringBuilder input = new StringBuilder();

        public static void Main()
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "End" || data == null)
                {
                    // Error reading from console 
                    break;
                }

                int i = data.IndexOf('(');
                if (i == -1)
                {
                    Console.WriteLine("error!");
                    Environment.Exit(0);
                }

                string k = data.Substring(0, i);
                if (!data.EndsWith(")"))
                {
                    Main();
                }

                string s = data.Substring(
                    i + 1,
                    data.Length - i - 2);
                string[] strings = s.Split(',');
                for (int j = 0; j < strings.Length; j++)
                {
                    strings[j] = strings[j].Trim();
                }
                if (k.StartsWith("AddPhone") && (strings.Length >= 2))
                {
                    Cmd("Cmd1", strings);
                }
                else if ((k.StartsWith("ChangePhone")) && (strings.Length == 2))
                {
                    Cmd("Cmd2", strings);
                }
                else if ((k == "List") && (strings.Length == 2))
                {
                    Cmd("Cmd3", strings);
                }
                else
                {
                    continue;
                }
            }
        }

        private static void Cmd(string cmd, string[] strings)
        {
            // first command
            if (cmd == "Cmd1")
            {
                string str0 = strings[0];
                var str1 = strings.Skip(1).ToList();
                for (int i = 0; i < str1.Count; i++)
                {
                    str1[i] = Conv(str1[i]);
                }

                bool flag = data.AddPhone(str0, str1);
                if (flag)
                {
                    Print("Phone entry created");
                }
                else
                {
                    Print("Phone entry merged");
                }
            }
            else if (cmd == "Cmd2")
            {
                Print(string.Empty + data.ChangePhone(Conv(strings[0]), Conv(strings[1])) + " numbers changed");
            }
            else
            {
                try
                {
                    IEnumerable<Class1> entries = data.ListEntries(int.Parse(strings[0]), int.Parse(strings[1]));
                    foreach (var entry in entries)
                    {
                        Print(entry.ToString());
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Print("Invalid range");
                }
            }
        }

        private static string Conv(string num)
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

        private static void Print(string text)
        {
            input.AppendLine(text);
            Console.WriteLine(text);
        }
    }
}
