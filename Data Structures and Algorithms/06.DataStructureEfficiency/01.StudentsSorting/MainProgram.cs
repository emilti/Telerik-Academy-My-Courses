﻿namespace StudentsSorting
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// A text file students.txt holds information about students and their courses in the following format:
    /// Using SortedDictionary<K, T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:
    /// Kiril  | Ivanov   | C#
    /// Stefka | Nikolova | SQL
    /// Stela  | Mineva   | Java
    /// Milena | Petrova  | C#
    /// Ivan   | Grigorov | C#
    /// Ivan   | Kolev    | SQL
    /// C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
    /// Java: Stela Mineva
    /// SQL: Ivan Kolev, Stefka Nikolova 
    /// </summary>
    public class MainProgram
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader(@"../../students.txt");
            using (reader)
            {
                SortedDictionary<string, List<Student>> courses = new SortedDictionary<string, List<Student>>();
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    var data = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student(data[0], data[1]);
                    if (courses.ContainsKey(data[2]))
                    {
                        List<Student> studentsInCourse = courses[data[2]];
                        studentsInCourse.Add(student);
                        courses[data[2]] = studentsInCourse;
                    }
                    else
                    {
                        courses.Add(data[2], new List<Student>() { student });
                    }
                }

                for (int i = 0; i < courses.Count; i++)
                {
                    List<Student> studentsInCourse = courses.ElementAt(i).Value;
                    var key = courses.ElementAt(i).Key;
                    studentsInCourse = studentsInCourse.OrderBy(st => st.LastName).ThenBy(st => st.FirstName).ToList();
                    courses[key] = studentsInCourse;
                    Console.Write(courses.ElementAt(i).Key + ": " + string.Join(", ", courses.ElementAt(i).Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
