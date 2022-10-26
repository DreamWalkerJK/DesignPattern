using FactoryMethodPattern.Interface;
using System;

namespace FactoryMethodPattern.Concrete
{
    public class ConcreteProductB : IProduct
    {
        public void Do()
        {
            Console.WriteLine("生产B产品");
        }
    }
}
