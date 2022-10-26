using FactoryMethodPattern.Interface;
using System;

namespace FactoryMethodPattern.Concrete
{
    public class ConcreteProductC : IProduct
    {
        public void Do()
        {
            Console.WriteLine("生产C产品");
        }
    }
}
