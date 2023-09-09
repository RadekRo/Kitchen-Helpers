using System;

namespace Kitchen_Helpers;

internal sealed class Chefs : Employee
{
    // private static Chefs instance;
    private Chefs(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
    {
    }
    private static Chefs _instance;

    public override void Shout()
    {
        Console.WriteLine("Faster!");
    }

    public void RequestIngredients()
    {
        Ingredients ingredient = Ingredients.meat;
        Console.WriteLine($"Give me: {ingredient}!");
    }

    public static Chefs GetInstance()
    {
        
        {
            if (_instance == null)
            {
                _instance = new Chefs("Greg", DateTime.Now, 2300);
            }
            return _instance;
        }
    }
}
