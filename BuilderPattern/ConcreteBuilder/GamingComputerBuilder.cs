using BuilderPattern.Builder;
using System;

namespace BuilderPattern.ConcreteBuilder
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "i7处理器";
            Console.WriteLine("i7处理器");
        }

        public override void BuildDisk()
        {
            computer.Disk = "512G SSD";
            Console.WriteLine("512G SSD");
        }

        public override void BuildGraphicsCard()
        {
            computer.GraphicsCard = "RTX 3090";
            Console.WriteLine("RTX 3090");
        }

        public override void BuildMainBoard()
        {
            computer.MainBoard = "HP主板";
            Console.WriteLine("HP主板");
        }

        public override void BuildMemory()
        {
            computer.Memory = "32G DDR4";
            Console.WriteLine("32G DDR4");
        }
    }
}
