using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Concrete
{
    public class ProductAFamilyB : IAbstractProductA
    {
        public void DoA()
        {
            Console.WriteLine("生产B族中的A产品");
        }
    }
}
