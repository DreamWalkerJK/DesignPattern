using AbstractFactoryPattern.Concrete;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Factory
{
    public class FactoryA : IAbstractFactory
    {
        public void Make()
        {
            IAbstractProductA productA = new ProductAFamilyA();
            productA.DoA();

            IAbstractProductB productB = new ProductBFamilyA();
            productB.DoB();
        }
    }
}
