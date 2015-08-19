namespace Student
{
    using System;
    using System.Linq;

    public class MainProgram
    {
        public static void Main()
        {
            Student a = new Student(
                "AAA",
                "BBB", 
                "CCC",
                322,
                "aaaa bbb", 
                "12345678", 
                "aaaaa@mail.bg",
                "courseAAAA", 
                SpecialtyEnum.aaaSp, 
                UniversityEnum.aaUn, 
                FacultyEnum.cccFac);
            Student b = new Student(
                "ZZZ", 
                "BBB", 
                "CCC",
                321, 
                "aaaa bbb",
                "12345678", 
                "aaaaa@mail.bg",
                "courseAAAA", 
                SpecialtyEnum.aaaSp,
                UniversityEnum.aaUn,
                FacultyEnum.cccFac);
            Student c = new Student(
                "AAA", 
                "BBB", 
                "CCC", 
                321, 
                "aaaa bbb",
                "12345678",
                "ttt@mail.bg",
                "courseAAAA", 
                SpecialtyEnum.aaaSp, 
                UniversityEnum.aaUn, 
                FacultyEnum.cccFac);
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine(b.ToString());
            Console.WriteLine();
            Console.WriteLine(c.ToString());
            Console.WriteLine("student a is student b:{0}", a.Equals(b));
            Console.WriteLine("student a is student c:{0}", a.Equals(c));
            Console.WriteLine("student a is student c:{0}", a == c);
            Console.WriteLine("student a is not student c:{0}", a != c);
            Console.WriteLine("student a is not student b:{0}", a != b);
            Console.WriteLine("Student not overriden hash code:{0} {1} {2}", a.FirstName.GetHashCode(), a.MiddleName.GetHashCode(), a.LastName.GetHashCode());
            Console.WriteLine("Student a overriden hash code:{0}", a.GetHashCode());
            var d = a.Clone();
            Console.WriteLine();
            Console.WriteLine("Cloned student a:");
            Console.WriteLine(d.ToString());
            var students = new Student[] { c, b, a }.OrderBy(x => x).ToArray();
            foreach (var st in students)
            {
                Console.WriteLine(st.FirstName + " " + st.MiddleName + " " + st.LastName + " " + st.SSN);
            }
        }
    }
}
