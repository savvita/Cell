using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cell c1 = new Cell(10);
            Cell c2 = new Cell(20);

            c1.Test();

            Console.WriteLine("======================");
            c2.Test();

            Console.WriteLine("======================");
            c1.Atack(c2);

            Console.WriteLine("======================");
            c1.Test();

            Console.WriteLine("======================");
            c2.Test();

            Console.WriteLine("======================");
            c2.Atack(c1);

            Console.WriteLine("======================");
            c1.Test();

            Console.WriteLine("======================");
            c2.Test();
        }
    }

}
