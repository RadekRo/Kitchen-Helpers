namespace Kitchen_Helpers;

public class Program
{
    static void Main(string[] args)
    {
        //var newWorker = new Employee("Radek", DateTime.Now, 2300);
        Chefs newWorker = new ("Greg", DateTime.Now, 2300);
        Console.WriteLine(newWorker);
        Chefs.RequestIngredients();
    }
}