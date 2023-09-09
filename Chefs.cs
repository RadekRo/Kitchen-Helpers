using System;

namespace Kitchen_Helpers;

public class Chefs : Employee
{
    public Chefs(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
    {
    }

    public override void Shout()
    {
        Console.WriteLine("Faster!");
    }

    public static void RequestIngredients()
    {
        Ingredients ingredient = Ingredients.meat;
        Console.WriteLine($"Give me: {ingredient}!");
    }
}
