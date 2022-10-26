using SimpleFactoryPattern.Interface;
using System;

namespace SimpleFactoryPattern.Concrete
{
    public class ConcreteProductC : IProduct
    {
        public void Do()
        {
            Console.WriteLine("生产C产品");
        }
    }
}
