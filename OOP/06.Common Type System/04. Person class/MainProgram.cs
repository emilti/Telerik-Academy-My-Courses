namespace Person
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Person a = new Person("aaa");
            Person b = new Person("bbb", 22);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}