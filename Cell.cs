using System;

namespace Test
{
    internal class Cell
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        private IMove mover;
        private IAtacked beAtacked;
        private IAtack atack;
        private IEat eating;
        private IDivision division;

        public Cell(double weight = 0, string name = "Unknown")
        {
            Name = name;
            Weight = weight;
            mover = new Walk();
            beAtacked = new BeBrave();
            atack = new BePoliteAgressor();
            eating = new EatPlankton();
            division = new Divided();
        }

        protected Cell(IEat eating, double weight = 0, string name = "Unknown"): this(weight, name)
        {
            this.eating = eating;
        }

        public override string ToString()
        {
            return $"{Name}: {Weight}";
        }

        public void SwitchMove()
        {
            if (mover.GetType().Name == "Walk")
                mover = new Run();
            else
                mover = new Walk();
        }

        public void SwitchAtacked()
        {
            if (beAtacked.GetType().Name == "BeBrave")
                beAtacked = new BeCoward();
            else
                beAtacked = new BeBrave();
        }

        public void SetMove(IMove mover)
        {
            this.mover = mover;
        }
        
        public void SetBeAtacked(IAtacked atacked)
        {
            this.beAtacked = atacked;
        }

        public void SetAtack(IAtack atack)
        {
            this.atack = atack;
        }

        public void GetAtacked(Cell cell)
        {
            if(cell.Weight > Weight)
            {
                beAtacked = new BeCoward();
                mover = new Run();
                atack = new BePoliteAgressor();
            }
            else
            {
                beAtacked = new BeBrave();
                mover = new Walk();
                atack = new BeAgressor();

                cell.SetBeAtacked(new BeCoward());
                cell.SetMove(new Run());
                cell.SetAtack(new BePoliteAgressor());
            }
        }

        public void Atack(Cell cell)
        {
            if (cell.Weight > Weight)
            {
                beAtacked = new BeCoward();
                mover = new Run();
                atack = new BePoliteAgressor();
            }
            else
            {
                beAtacked = new BeBrave();
                atack = new BeAgressor();
                mover = new Walk();

                cell.SetBeAtacked(new BeCoward());
                cell.SetMove(new Run());
                cell.SetAtack(new BePoliteAgressor());
            }
        }

        public void Test()
        {
            Console.WriteLine(this);
            Console.WriteLine("Move:");
            mover.MoveUp();
            mover.MoveDown();
            mover.MoveLeft();
            mover.MoveRight();

            eating.Eat();

            Console.Write("Being atacked: ");
            beAtacked.GetAtacked();
            Console.Write("Atack: ");
            atack.Atack();

            var childs = division.Divide();
            if(childs != null)
            {
                Console.WriteLine("The cell has divided");
            }
            else
            {
                Console.WriteLine("The cell is old and weak and don't want to divide");
            }


        }
    }
}
