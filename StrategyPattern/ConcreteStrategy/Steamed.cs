using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    public class Steamed : Handling
    {
        public override void Operating()
        {
            Console.WriteLine("蒸食");
        }
    }
}
