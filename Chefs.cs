using System;

namespace Kitchen_Helpers;

public class Chefs : Employee
{
    public Chefs(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
    {
    }

    public void Shout()
    {
        Console.WriteLine("Faster!");
    }

    public static void RequestIngredients()
    {
        Ingredients skladniki = Ingredients.meat;
        Console.WriteLine(skladniki);
    }
}
