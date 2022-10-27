using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Context;
using System;

namespace StrategyPattern
{
    /// <summary>
    /// 策略模式：Strategy Pattern
    /// 定义一系列算法，封装每个算法，并使它们可以互换，不同的策略可以让算法独立于它们的客户而变化
    /// 优点：算法策略可以自由切换、避免使用多重条件转移语句，如：if...else, switch、符合开闭原则
    /// 缺点：必须知道所有的策略，并且自行决定使用哪一个策略类、代码中会产生很多策略类，增加维护难度
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food(new Steamed());
            food.HandleFood();

            food = new Food(new Fired());
            food.HandleFood();

            food = new Food(new Boiled());
            food.HandleFood();

            Console.ReadKey();
        }
    }
}
