using System;

namespace Test
{
    internal class Run : IMove
    {
        public void MoveDown()
        {
            Console.WriteLine("Run down");
        }

        public void MoveLeft()
        {
            Console.WriteLine("Run left");
        }

        public void MoveRight()
        {
            Console.WriteLine("Run right");
        }

        public void MoveUp()
        {
            Console.WriteLine("Run up");
        }
    }
}
