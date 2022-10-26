using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Concrete
{
    public class ProductBFamilyA : IAbstractProductB
    {
        public void DoB()
        {
            Console.WriteLine("生产A族中的B产品");
        }
    }
}
