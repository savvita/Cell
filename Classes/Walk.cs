using System;

namespace Test
{
    internal class Walk : IMove
    {
        public void MoveDown()
        {
            Console.WriteLine("Walk down");
        }

        public void MoveLeft()
        {
            Console.WriteLine("Walk left");
        }

        public void MoveRight()
        {
            Console.WriteLine("Walk right");
        }

        public void MoveUp()
        {
            Console.WriteLine("Walk up");
        }
    }
}
