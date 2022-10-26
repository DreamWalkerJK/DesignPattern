using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Concrete
{
    public class ProductAFamilyA : IAbstractProductA
    {
        public void DoA()
        {
            Console.WriteLine("生产A族中的A产品");
        }
    }
}
