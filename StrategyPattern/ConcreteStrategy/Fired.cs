using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    public class Fired : Handling
    {
        public override void Operating()
        {
            Console.WriteLine("炒食");
        }
    }
}
