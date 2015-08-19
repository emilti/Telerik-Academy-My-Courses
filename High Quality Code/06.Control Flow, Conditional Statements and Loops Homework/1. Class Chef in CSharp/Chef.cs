namespace Cooking
{
    using System;

        public class Chef
        {    
            public void Cook()
            {
                Potato potato = this.GetPotato();
                this.Peel(potato);
                this.Cut(potato);

                Carrot carrot = this.GetCarrot(); 
                this.Peel(carrot); 
                this.Cut(carrot);

                Bowl bowl = this.GetBowl();
                bowl.Add(carrot);
                bowl.Add(potato);
            }

            private Bowl GetBowl()
            {
                Bowl newBowl = new Bowl();
                return newBowl;
            }

            private Carrot GetCarrot()
            {
                Carrot newCarrot = new Carrot();
                return newCarrot;
            }

            private void Cut(Vegetable vegetable)
            {
                throw new NotImplementedException();
            }
            
            private Potato GetPotato()
            {
                Potato newPotato = new Potato();
                return newPotato;
            }

            private void Peel(Vegetable vegetable)
            {
                throw new NotImplementedException();
            }
    }
}
