using System;

namespace Test
{
    internal class EatCell : IEat
    {
        public void Eat()
        {
            Console.WriteLine("Oops! It is eating another cell");
        }

    }
}
