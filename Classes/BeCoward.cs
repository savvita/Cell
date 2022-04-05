using System;

namespace Test
{
    internal class BeCoward : IAtacked
    {
        public void GetAtacked()
        {
            Console.WriteLine("Run away!");
        }
    }
}
