﻿namespace StringsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StringsTestService : IStringsTestService
    {
        public int TestString(string containee, string container)
        {
            int count = 0;
            string currentString = container;
            for (int i = 0; i < container.Length; i++)
            {
                if (i + containee.Length <= container.Length)
                {
                    currentString = container.Substring(i, containee.Length);
                    if (currentString.CompareTo(containee) == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
