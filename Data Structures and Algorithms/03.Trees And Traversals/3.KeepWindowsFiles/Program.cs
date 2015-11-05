namespace TreeTraverse
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            string file = @"C:\Windows";
            Folder root = new Folder(file);           
            DFS(root);
            Console.WriteLine(root.SizeOfAllChildFiles);
        }

        public static void DFS(Folder folder)
        {
            foreach (string fileName in Directory.GetFiles(folder.Name))
            {
               FileInfo fileInfo = new FileInfo(fileName);
               long size = fileInfo.Length;              
               File file = new File(fileName, size);
               Console.WriteLine(file.Name + " - " + file.Size);
               folder.SizeOfAllChildFiles = folder.SizeOfAllChildFiles + size;
               folder.Files.Add(file);
            }

            try
            {
                foreach (string d in Directory.GetDirectories(folder.Name))
                {                    
                    Folder currentFolder = new Folder(d);
                    folder.ChildFolders.Add(currentFolder);
                    DFS(currentFolder);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}
