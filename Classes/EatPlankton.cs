using System;

namespace Test
{
    internal class EatPlankton : IEat
    {
        public void Eat()
        {
            Console.WriteLine("Ugh! It is eating some terrible food");
        }

    }
}
