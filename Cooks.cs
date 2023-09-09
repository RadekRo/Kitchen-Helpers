using System;

namespace Kitchen_Helpers
{
    public class Cooks : Employee
    {
        public Cooks(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
        {
        }

        public override void Shout()
        {
            Console.WriteLine("Aaa! I'm cooking!");
        }
    }
}
