using SimpleFactoryPattern.Interface;
using System;

namespace SimpleFactoryPattern.Concrete
{
    public class ConcreteProductB : IProduct
    {
        public void Do()
        {
            Console.WriteLine("生产B产品");
        }
    }
}
