namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainProgram
    {
        public static void Main()
        {
            List<Student> studentsList = new List<Student>
            {
           new Student("Gosho", "Petkov", "042000", "02203050", "gosho@abv.bg", new List<int> { 2, 3, 4 }, 2),
           new Student("Pesho", "Hubavecov", "042006", "25503250", "peshoo@ddd.bg", new List<int> { 2, 2, 2 }, 1),
           new Student("Gocho", "Gochev", "042001", "02202220", "goch@abv.bg", new List<int> { 6, 6, 6 }, 2),
           new Student("Mmmm", "Aaaaa", "012006", "202210", "mmmm@wwww.bg", new List<int> { 6, 2, 2 }, 3),
           new Student("Aaaa", "Aaaaa", "012007", "20221550", "mmmm@abv.bg", new List<int> { }, 3),
           new Student("bbb", "bb", "012007", "0220221550", "mmmm@abv.bg", new List<int> { }, 2),
           new Student("ccc", "wwww", "012006", "0220221550", "mmmm@abv.bg", new List<int> { 2, 2, 3 }, 2)
           };

            Group groupMath = new Group(1, "Mathematics");
            Group groupPhilosophy = new Group(2, "Philosophy");
            Group groupLiterature = new Group(3, "Literature");
            List<Group> listOfGroups = new List<Group>
            {
            new Group(1, "Mathematics"),
            new Group(2, "Philosophy"),
            new Group(3, "Literature")
            };

            GroupMath(studentsList, listOfGroups);

            // P9
            var group2LINQ = Group2LINQMethod(studentsList);
            Console.WriteLine("Sorted list using LINQ:");
            Console.WriteLine(string.Join(", ", group2LINQ));
            Console.WriteLine();

            // P10
            var group2Lambda = Group2LambdaMethod(studentsList);
            Console.WriteLine("Sorted list using lambda operations and extensions:");
            Console.WriteLine(string.Join(", ", group2Lambda));
            Console.WriteLine();

            // P11
            var emailGroup = EmailCheck(studentsList);
            Console.WriteLine("All students with abv.bg mail provider:");
            Console.WriteLine(string.Join(", ", emailGroup));
            Console.WriteLine();

            // P12
            var sofiaPhonesGroup = SofiaPhones(studentsList);
            Console.WriteLine("All students with Sofia phones:");
            Console.WriteLine(string.Join(", ", sofiaPhonesGroup));
            Console.WriteLine();

            // P13
            MarksSix(studentsList);

            // P14
            MarksTwo(studentsList);

            // P15
            List<int> extractedMarks = AllMarks(studentsList);
            Console.WriteLine("All marks of the students with FN 2006:");
            Console.WriteLine(string.Join(", ", extractedMarks));
            Console.WriteLine();

            // P18
            SortedByGroupsNumberLINQ(studentsList);

            // P19
            SortedByGroupsNumberExtensionMethods(studentsList);
        }
       
        // P9
        public static IEnumerable<Student> Group2LINQMethod(List<Student> studentsList)
        {
            IEnumerable<Student> group2LINQ = from st in studentsList
                                              where st.GroupNumber == 2
                                              orderby st.FirstName
                                              select st;
            return group2LINQ;
        }

        public static IEnumerable<Student> Group2LambdaMethod(List<Student> studentsList)
        {
            var group2Lambda = studentsList.Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName).ToList();
            return group2Lambda;
        }

        // P11
        public static List<Student> EmailCheck(List<Student> studentsList)
        {
            // List<Student> abvList = studentsList.Where
            //    (st => st.Email.Substring(st.Email.IndexOf('@')).
            //        CompareTo("abv.bg") == 0).ToList();
            List<Student> abvList = (from st in studentsList
                                     where (st.Email.Substring(st.Email.IndexOf('@')).
                                     CompareTo("@abv.bg") == 0)
                                     select st).
                                     ToList();

            return abvList;
        }

        // P12
        public static List<Student> SofiaPhones(List<Student> studentsList)
        {
            List<Student> sofiaPhonesGroup = (from st in studentsList
                                              where st.Tel.Substring(0, 2).
                                              CompareTo("02") == 0
                                              select st).ToList();
            return sofiaPhonesGroup;
        }

        // P13
        public static void MarksSix(List<Student> studentsList)
        {
            var marksSixGroup = from st in studentsList
                                where st.Marks.Contains(6)
                                select new
                                 {
                                     FullName = st.FirstName + " " + st.LastName,
                                     MarksList = st.Marks
                                 };
            Console.WriteLine("All students who have at least one mark equal to 6:");
            foreach (var x in marksSixGroup)
            {
                Console.WriteLine(x.FullName);
                Console.WriteLine(string.Join(", ", x.MarksList));
            }

            Console.WriteLine();
        }

        // P14
        public static void MarksTwo(List<Student> studentsList)
        {
            var marksTwoGroup = studentsList.FindAll(st => st.Marks.Count(x => x.Equals(2)) == 2)
                .Select(st => new
           {
               FullName = st.FirstName + " " + st.LastName,
               MarksList = st.Marks
           });
            Console.WriteLine("All students who have at least two mark equal to 2:");
            foreach (var x in marksTwoGroup)
            {
                Console.WriteLine(x.FullName);
                Console.WriteLine(string.Join(", ", x.MarksList));
            }

            Console.WriteLine();
        }

        // P15
        public static List<int> AllMarks(List<Student> studentsList)
        {
            List<Student> students2006 = studentsList.Where(st => st.FN[4] == '0' && st.FN[5] == '6').ToList();
            List<int> allMarks = new List<int>();
            foreach (var st in students2006)
            {
                allMarks.AddRange(st.Marks);
            }

            return allMarks;
        }

        // P16
        public static void GroupMath(List<Student> studentsList, List<Group> listOfGroups)
        {
            var mathGroups = from st in studentsList
                             join gr in listOfGroups on st.GroupNumber equals gr.GroupNumber
                             where st.GroupNumber == 1
                             select st;          
        }
         
        // P18
        private static void SortedByGroupsNumberLINQ(List<Student> studentsList)
        {
            var groups = from st in studentsList
                         group st by st.GroupNumber into groupsNew
                         select groupsNew;
            Console.WriteLine("Grouped using LINQ:");
            foreach (var group in groups)
            {
                Console.WriteLine("Group Number: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }

            Console.WriteLine();
        }
        
        // P19
        private static void SortedByGroupsNumberExtensionMethods(List<Student> studentsList)
        {
            var groups = studentsList.GroupBy(x => x.GroupNumber).ToList();
            Console.WriteLine("Grouped using lambda operations and extension methods:");
            foreach (var group in groups)
            {
                Console.WriteLine("Group Number: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }
        }
    }
}