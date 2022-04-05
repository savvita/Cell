using System;

namespace Test
{
    internal class Cannibal : Cell
    {
        public Cannibal(double weight = 0, string name = "Unknown"): base(new EatCell(), weight, name)
        {
        }
    }
}
