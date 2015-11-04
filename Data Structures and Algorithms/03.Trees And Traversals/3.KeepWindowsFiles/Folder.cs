namespace TreeTraverse
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Folder
    {    
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public long SizeOfAllChildFiles { get; set; }

        public void GetAllFileSizes(Folder folder)
        {
            foreach (string fileName in Directory.GetFiles(folder.Name))
            {
                FileInfo fInfo = new FileInfo(fileName);
                long currentSize = fInfo.Length;
                this.SizeOfAllChildFiles = this.SizeOfAllChildFiles + currentSize;
                File file = new File(fileName, currentSize);
                folder.Files.Add(file);
            }

            try
            {
                foreach (string d in Directory.GetDirectories(folder.Name))
                {
                    Folder currentFolder = new Folder(d);
                    folder.ChildFolders.Add(currentFolder);
                    GetAllFileSizes(currentFolder);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }           
        }
    }
}
