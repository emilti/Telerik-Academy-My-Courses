namespace Animals
{
    using System.Linq;

    public class MainProgram
    {
        public static void Main()
        {
            Animal[] arrayOfAnimals = 
            {
             new Dog("Sharo1", 12, Gender.Male),            
             new Dog("Sharka1", 10, Gender.Female),
             new Frog("Jabka1", 4, Gender.Female),
             new Frog("Jabka2", 7, Gender.Female),
             new Kitten("Pussy1", 3),
             new Kitten("Pussy2", 7),
             new Tomcat("Kotarak1", 4),
             new Tomcat("Kotarak2", 13),
        };
            var arrayOfDogs = arrayOfAnimals.OfType<Dog>().Cast<Dog>();
            var arrayOfCats = arrayOfAnimals.OfType<Cat>().Cast<Cat>();
            var arrayOfFrogs = arrayOfAnimals.OfType<Frog>().Cast<Frog>();
            double averageDog = Animal.GetAverage(arrayOfDogs);
            double averageCat = Animal.GetAverage(arrayOfCats);
            double averageFrog = Animal.GetAverage(arrayOfFrogs);
            foreach (var an in arrayOfAnimals)
            {
                System.Console.WriteLine(an);
            }

            System.Console.WriteLine("Average age of Dogs: {0}", averageDog);
            System.Console.WriteLine("Average age of Cats: {0}", averageCat);
            System.Console.WriteLine("Average age of Frogs: {0}", averageFrog);
        }
    }
}
