using BuilderPattern.Builder;
using System;

namespace BuilderPattern.ConcreteBuilder
{
    public class BusinessComputerBuilder : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "i3处理器";
            Console.WriteLine("i3处理器");
        }

        public override void BuildDisk()
        {
            computer.Disk = "256G SSD";
            Console.WriteLine("256G SSD");
        }

        public override void BuildGraphicsCard()
        {
            computer.GraphicsCard = "锐炬xe";
            Console.WriteLine("锐炬xe");
        }

        public override void BuildMainBoard()
        {
            computer.MainBoard = "HP主板";
            Console.WriteLine("HP主板");
        }

        public override void BuildMemory()
        {
            computer.Memory = "8G DDR4";
            Console.WriteLine("8G DDR4");
        }
    }
}
