namespace School
{
    public class MainProgram
    {
        public static void Main()
        {
            Student student1 = new Student("Aaaa Bbb", 1);
            Student student2 = new Student("Cccc Ddd", 2);
            Student student3 = new Student("Eeee Fff", 3, "ZZZZZZZZZZZZZ");

            Teacher teacher1 = new Teacher("Zzzz yyyy");
            Teacher teacher2 = new Teacher("Xxxx wwww");

            Discipline oop = new Discipline("oop", 12, 10, "AAAAAAAA");
            Discipline csharp = new Discipline("Csharp", 20, 14);
            Discipline java = new Discipline("Java", 15, 16);

            teacher1.AddDisicipline(oop);
            teacher1.AddDisicipline(csharp);
            teacher2.AddDisicipline(oop);
            teacher1.ListOfDisciplines.Add(java);
            School mySchool = new School();
            ClassInSchool myClass = new ClassInSchool("MyClassName");
            myClass.AddStudent(student1);
            myClass.AddStudent(student2);
            myClass.AddStudent(student3);
            myClass.RemoveStudent(student1);
            myClass.AddTeacher(teacher1);
            myClass.AddTeacher(teacher2);
            mySchool.AddClass(myClass);
            System.Console.WriteLine(myClass);
        }
    }
}
