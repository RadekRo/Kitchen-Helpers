namespace Kitchen_Helpers;

public class Employee
{
    string Name { get; set; }
    DateTime BirthDate { get; set; }
    int Salary { get; set; }

    public Employee(string name, DateTime birthdate, int salary)
    {
        Name = name;
        BirthDate = birthdate;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name}, {BirthDate}, {Salary}";
    }
}
