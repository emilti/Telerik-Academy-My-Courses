namespace CohesionAndCoupling
{
    using System;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("fileName is null or empty.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("fileName is null or empty.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
