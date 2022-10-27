using System;

namespace StrategyPattern.Strategy
{
    public class Handling
    {
        public virtual void Operating()
        {
            Console.WriteLine("基础处理食物");
        }
    }
}
