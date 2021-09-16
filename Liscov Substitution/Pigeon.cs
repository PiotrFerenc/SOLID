using System;

namespace Liscov_Substitution
{
    public class Pigeon : Bird, IFly
    {
        public override void Eat()
        {
            Console.WriteLine("Pigeon is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Pigeon is flying");

        }
    }
}