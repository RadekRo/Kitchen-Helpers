namespace Kitchen_Helpers;

public class Employee
{
    string Name { get; set; }
    DateTime BirthDate { get; set; }
    int Salary { get; set; }
    double Tax { get; set; }
    const double TaxRate = 0.99; 

    public Employee(string name, DateTime birthdate, int salary)
    {
        Name = name;
        BirthDate = birthdate;
        Salary = salary;
        Tax = Salary * TaxRate;
    }

    public override string ToString()
    {
        return $"{Name}, Date of birth: {BirthDate}, Salary: {Salary}, Tax: {Tax}";
    }

    public virtual void Shout()
    {
        Console.Write("Aaa!");
    }
}
