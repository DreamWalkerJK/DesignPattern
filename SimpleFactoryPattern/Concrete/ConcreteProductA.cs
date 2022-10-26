using SimpleFactoryPattern.Interface;
using System;

namespace SimpleFactoryPattern.Concrete
{
    public class ConcreteProductA : IProduct
    {
        public void Do()
        {
            Console.WriteLine("生产A产品");
        }
    }
}
