using System;

namespace Kitchen_Helpers;

public class Chefs : Employee
{
    // private static Chefs instance;
    public Chefs(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
    {
    }


    public override void Shout()
    {
        Console.WriteLine("Faster!");
    }

    public void RequestIngredients()
    {
        Ingredients ingredient = Ingredients.meat;
        Console.WriteLine($"Give me: {ingredient}!");
    }

    //public static Chefs Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = new Chefs("Greg", DateTime.Now, 2300);
    //        }
    //        return instance;
    //    }
    //}
}
