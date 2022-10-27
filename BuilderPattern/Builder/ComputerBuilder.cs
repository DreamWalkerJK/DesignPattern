using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();
        public abstract void BuildCPU();
        public abstract void BuildMemory();
        public abstract void BuildDisk();
        public abstract void BuildGraphicsCard();
        public abstract void BuildMainBoard();

        public Computer CreateComputer()
        {
            return computer;
        }
    }
}
