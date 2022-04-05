using System;

namespace Test
{
    internal class BePoliteAgressor : IAtack
    {
        public void Atack()
        {
            Console.WriteLine("Sorry, but i'll atack you. Don't blame me, please");
        }
    }
}
