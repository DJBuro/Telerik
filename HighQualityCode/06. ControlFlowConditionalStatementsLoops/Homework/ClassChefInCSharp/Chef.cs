namespace Homework
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            Peel(potato);
            Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Potato GetPotato()
        {
            // ...
        }

        private Carrot GetCarrot()
        {
            // ...
        }

        private Bowl GetBowl()
        {
            // ... 
        }

        private void Cut(Vegetable potato)
        {
            // ...
        }
    }
}
