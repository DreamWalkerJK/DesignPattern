using FactoryMethodPattern.Concrete;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Factory
{
    public class FactoryB : IFactory
    {
        public IProduct Make()
        {
            return new ConcreteProductB();
        }
    }
}
