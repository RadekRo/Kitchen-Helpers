namespace Kitchen_Helpers;

public class Program
{
    static void Main(string[] args)
    {
        //var newWorker = new Employee("Radek", DateTime.Now, 2300);
        Chefs newChef = new ("Greg", DateTime.Now, 2300);
        Cooks newCook = new("Kate", DateTime.Now, 1500);
        Employee newEmployee = new("Bob", DateTime.Now, 1800);
        Console.WriteLine(newChef);
        Console.WriteLine(newCook);
        Console.WriteLine(newEmployee);
        newChef.RequestIngredients();
        newChef.Shout();
        newCook.Shout();

    }
}