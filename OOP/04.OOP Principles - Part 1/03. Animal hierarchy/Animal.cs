namespace Animals
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; protected set; }

        public int Age { get; protected set; }

        public Gender Sex { get; protected set; }

        public static double GetAverage(IEnumerable<Animal> array)
        {
            double average = array.Average(x => x.Age);
            return average;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return "Name:" + this.Name + " " + "Animal:" + this.GetType().Name + " " + " " + "Age:" + this.Age + " " + "Sex:" + this.Sex;
        }
    }
}
