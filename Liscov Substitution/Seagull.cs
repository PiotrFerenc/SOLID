using System;

namespace Liscov_Substitution
{
    public class Seagull : Bird, IFly
    {
        public override void Eat()
        {
            Console.WriteLine("Seagull is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Seagull is flying");
        }
    }
}