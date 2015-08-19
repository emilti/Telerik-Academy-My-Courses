namespace Animals
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, Gender sex = Gender.Female)
            : base(name, age, sex)
        { 
        }

        public override void MakeSound()
        {
            string sound = "pispsps";
        }
    }
}
