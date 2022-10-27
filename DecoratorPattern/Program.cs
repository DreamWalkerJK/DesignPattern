using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 装饰器模式：Decorator Pattern
    /// 又称包装模式，指不改变原有对象的基础上，将功能附加到对象上，提供比继承更有弹性的替代方案
    /// 优点：继承的替代方案
    /// 缺点：会产生更多类，增加程序复杂性
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FastFood riceFood = new FiredRice(15, "炒饭");
            Console.WriteLine($"{riceFood.desc}:{riceFood.TotalCost()}元");

            FastFood riceAddEgg = new FiredRice(15, "炒饭");
            riceAddEgg = new AddEgg(riceAddEgg, 1.5, "加鸡蛋");
            Console.WriteLine($"{riceAddEgg.desc}:{riceAddEgg.TotalCost()}元");

            FastFood noodlesFood = new FiredNoodles(13, "炒面");
            Console.WriteLine($"{noodlesFood.desc}:{noodlesFood.TotalCost()}元");

            FastFood noodlesAddBeef = new FiredNoodles(13, "炒面");
            noodlesAddBeef = new AddBeef(noodlesAddBeef, 5, "加牛肉");
            Console.WriteLine($"{noodlesAddBeef.desc}:{noodlesAddBeef.TotalCost()}元");

            Console.ReadKey();
        }
    }
}
