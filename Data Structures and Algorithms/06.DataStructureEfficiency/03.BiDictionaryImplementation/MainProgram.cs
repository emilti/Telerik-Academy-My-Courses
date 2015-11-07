namespace BiDictionaryImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MainProgram
    {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static void Main()
        {
            BiDictionary<string, string, Student> students = new BiDictionary<string, string, Student>();
            List<string> firstKeysTest = new List<string>();
            List<string> secondKeysTest = new List<string>();
            List<string> bothKeysTest = new List<string>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var lengthFirstName = random.Next(2, 20);
                string firstName = GetRandomString(lengthFirstName, random);
                var lengthLastName = random.Next(2, 20);
                string lastName = GetRandomString(lengthLastName, random);
                Student student1 = new Student(firstName, lastName);
                students.Add(student1.FirstName, student1.LastName, student1);
                firstKeysTest.Add(student1.FirstName);
                secondKeysTest.Add(student1.LastName);
                bothKeysTest.Add(student1.FirstName + student1.LastName);
                if (i % 2 == 0)
                {
                    Student student2 = new Student(firstName, lastName);
                    students.Add(student2.FirstName, student2.LastName, student2);
                    firstKeysTest.Add(student2.FirstName);
                    secondKeysTest.Add(student2.LastName);
                    bothKeysTest.Add(student2.FirstName + student2.LastName);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                var searchedFirstNameIndex = random.Next(0, firstKeysTest.Count);
                var studentsByFirstName = students.FindByFirstKey(firstKeysTest[searchedFirstNameIndex]);
                Console.WriteLine("New Search");
                Console.WriteLine("Students searched by first name:");
                foreach (var st in studentsByFirstName)
                {
                    Console.WriteLine("Student:" + st.FirstName + " " + st.LastName);
                }

                var searchedLastNameIndex = random.Next(0, secondKeysTest.Count);
                var studentsByLastName = students.FindBySecondKey(secondKeysTest[searchedLastNameIndex]);                
                Console.WriteLine("Students searched by last name:");
                foreach (var st in studentsByLastName)
                {
                    Console.WriteLine("Student:" + st.FirstName + " " + st.LastName);
                }               
                
                var studentsByBothNames = students.FindByBothKeys(firstKeysTest[i], secondKeysTest[i]);
                Console.WriteLine("Students searched by both names:");
                foreach (var st in studentsByBothNames)
                {
                    Console.WriteLine("Student:" + st.FirstName + " " + st.LastName);
                }

                Console.WriteLine();
            }
        }

        private static string GetRandomString(int length, Random random)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var letter = random.Next(0, Alphabet.Length);
                sb.Append(Alphabet[letter]);
            }

            return sb.ToString();
        }
    }
}
