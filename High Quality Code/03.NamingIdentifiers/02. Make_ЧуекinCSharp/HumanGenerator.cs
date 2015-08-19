namespace PeopleGenerator
{
    using System;

    public class HumanGenetator
    {
        public void GenerateHuman(int age)
        {
            Human human = new Human();
            human.Age = age;
            if (age % 2 == 0)
            {
                human.Name = "Батката";
                human.Gender = Gender.Male;
            }
            else
            {
                human.Name = "Мацето";
                human.Gender = Gender.Female;
            }
        }
    }
}
