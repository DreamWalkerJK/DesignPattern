using AbstractFactoryPattern.Concrete;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Factory
{
    public class FactoryB : IAbstractFactory
    {
        public void Make()
        {
            IAbstractProductA productA = new ProductAFamilyB();
            productA.DoA();

            IAbstractProductB productB = new ProductBFamilyB();
            productB.DoB();
        }
    }
}
