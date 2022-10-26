using FactoryMethodPattern.Concrete;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Factory
{
    public class FactoryA : IFactory
    {
        public IProduct Make()
        {
            return new ConcreteProductA();
        }
    }
}
