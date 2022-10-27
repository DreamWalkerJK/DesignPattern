using BuilderPattern.Builder;
using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;
using BuilderPattern.Product;
using System;

namespace BuilderPattern
{
    /// <summary>
    /// 建造者模式：Builder Pattern
    /// 一个复杂对象的构建与其表示相分离，使得同样的构建过程可以创建不同的表示
    /// 优点：松耦合、易拓展
    /// 缺点：创建的产品其组成部分相似，如果产品之间差异较大，不建议使用、如果内部变化复杂，会有很多的建造类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("商务本：");
            BusinessComputerBuilder business = new BusinessComputerBuilder();
            ShowComputer(business);

            Console.WriteLine("游戏本：");
            GamingComputerBuilder gaming = new GamingComputerBuilder();
            ShowComputer(gaming);

            Console.ReadKey();
            
        }

        private static void ShowComputer(ComputerBuilder builder)
        {
            ComputerDirector director = new ComputerDirector(builder);
            Computer computer = director.AssembleComputer();
            Console.WriteLine();
        }
    }
}
