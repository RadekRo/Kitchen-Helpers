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
            if (this.Knives < 1)
            {
                base.Shout();
            }
            else
            {
                Console.Write(" I'm cooking!\n");
            }
        }
    }
}
