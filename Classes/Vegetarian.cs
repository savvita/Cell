using System;

namespace Test
{
    internal class Vegetarian : Cell
    {
        public Vegetarian(double weight = 0, string name = "Unknown"): base(new EatPlankton(), weight, name)
        {
        }
    }
}
