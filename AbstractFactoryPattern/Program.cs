using AbstractFactoryPattern.Factory;
using System;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 抽象工厂模式：Abstract Factory Pattern
    /// 优点：需要产品族时，可保证始终只有同一个产品族的产品、可拓展性满足开闭原则
    /// 缺点：规定了所有可能被创建的产品集合，产品族中扩展新产品困难
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            new FactoryA().Make();

            new FactoryB().Make();

            Console.ReadKey();
        }
    }
}
