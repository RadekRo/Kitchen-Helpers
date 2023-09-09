namespace Kitchen_Helpers;

public class Program
{
    static void Main(string[] args)
    {
        //var newWorker = new Employee("Radek", DateTime.Now, 2300);

        //Chefs newChef = new ("Greg", DateTime.Now, 2300);
        //Chefs newChef2 = new("Greg2", DateTime.Now, 2500);
        Cooks newCook = new("Kate", DateTime.Now, 1500);
        Employee newEmployee = new("Bob", DateTime.Now, 1800);
        KitchenHelpers KitchenHelper1 = new("Jane", DateTime.Now, 1200);
        KitchenHelpers KitchenHelper2 = new("Jude", DateTime.Now, 1100);

        //Console.WriteLine(newChef);
        //Console.WriteLine(newChef2);
        Console.WriteLine(newCook);
        Console.WriteLine(newEmployee);
        //newChef.RequestIngredients();
        //newChef.Shout();
        //newCook.Shout();
        Console.WriteLine("KitchenHlelper1 inventory before request " + KitchenHelper1.Inventory[Ingredients.potato]);
        Console.WriteLine("KitchenHlelper2 inventory before request " + KitchenHelper2.Inventory[Ingredients.potato]);
        List<KitchenHelpers> KitchenHelpersList = new();
        KitchenHelpersList.Add(KitchenHelper1);
        KitchenHelpersList.Add(KitchenHelper2);
        int KitchenHelperIndex = 0;
        foreach (KitchenHelpers KitchenHelper in KitchenHelpersList)
        {
            if (KitchenHelper.ProvideIngredient(Ingredients.potato) == 1)
            { 
                Console.WriteLine("Here you are!");
                break;
            }
            
            if (KitchenHelperIndex == KitchenHelpersList.Count - 1) KitchenHelper.Shout();
            KitchenHelperIndex++; 
        }


        Console.WriteLine("KitchenHlelper1 inventory after request " + KitchenHelper1.Inventory[Ingredients.potato]);
        Console.WriteLine("KitchenHlelper2 inventory after request " + KitchenHelper2.Inventory[Ingredients.potato]);

        newCook.Shout();
        newCook.Knives = 1;
        newCook.Shout();
    }
}