using SimpleFactoryPattern.Factory;
using SimpleFactoryPattern.Interface;
using System;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 简单工厂模式 Simple Factory Pattern
    /// 优点：结构简单、调用方便
    /// 缺点：工厂类单一、产品基数过多时代码臃肿（switch...case分支过多）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IProduct productA = SimpleFactory.Make("A");
            productA.Do();

            IProduct productB = SimpleFactory.Make("B");
            productB.Do();

            IProduct productC = SimpleFactory.Make("C");
            productC.Do();

            Console.ReadKey();
        }
    }
}
