using FactoryMethodPattern.Factory;
using FactoryMethodPattern.Interface;
using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂方法模式：Factory Method Pattern
    /// 优点：灵活性增强、解耦类、满足（迪米特法则、依赖倒置原则、里氏替换原则）
    /// 缺点：类的个数容易过多、抽象/接口产品只能生产一种产品
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IProduct productA = new FactoryA().Make();
            productA.Do();

            IProduct productB = new FactoryB().Make();
            productB.Do();

            IProduct productC = new FactoryC().Make();
            productC.Do();

            Console.ReadKey();
        }
    }
}
