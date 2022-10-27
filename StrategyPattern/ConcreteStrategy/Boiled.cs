using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    public class Boiled : Handling
    {
        public override void Operating()
        {
            Console.WriteLine("煮食");
        }
    }
}
