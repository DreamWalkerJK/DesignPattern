using FactoryMethodPattern.Interface;
using System;

namespace FactoryMethodPattern.Concrete
{
    public class ConcreteProductA : IProduct
    {
        public void Do()
        {
            Console.WriteLine("生产A产品");
        }
    }
}
