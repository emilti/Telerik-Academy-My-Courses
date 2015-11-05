// 2.Write a program to traverse the directory C:\WINDOWS and all its 
// subdirectories recursively and to display all files matching the mask *.exe. 
// Use the class System.IO.Directory.
namespace TreeTraverse
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            DirSearch(@"C:\Windows");
        }

        private static void DirSearch(string dir)
        {
            foreach (string f in Directory.GetFiles(dir))
            {
                var extension = Path.GetExtension(f);
                if (extension == ".exe")
                {
                    Console.WriteLine(f);
                }
            }

            try
            {
                foreach (string d in Directory.GetDirectories(dir))
                {
                    DirSearch(d);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}