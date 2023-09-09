using System;


namespace Kitchen_Helpers
{
    internal class KitchenHelpers : Employee
    {
        public KitchenHelpers(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
        {
        }

        public Dictionary<Ingredients, int> Inventory = new Dictionary<Ingredients, int>
        {
            { Ingredients.meat, new Random().Next(0, 3) },
            { Ingredients.potato, new Random().Next(0, 3)  },
            { Ingredients.carrot, new Random().Next(0, 3)  }
        };

        
        public int ProvideIngredient(Ingredients enumValue)
        {
            if (Inventory[enumValue] > 0)
            {
                Inventory[enumValue]--;
                return 1;
                
            }
            else
            {
                return 0;
            }
        }
        public override void Shout()
        {
            Console.WriteLine("We're all out!");
        }
    }
}

