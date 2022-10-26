using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Concrete
{
    public class ProductBFamilyB : IAbstractProductB
    {
        public void DoB()
        {
            Console.WriteLine("生产B族中的B产品");
        }
    }
}
