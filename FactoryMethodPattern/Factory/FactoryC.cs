using FactoryMethodPattern.Concrete;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Factory
{
    public class FactoryC : IFactory
    {
        public IProduct Make()
        {
            return new ConcreteProductC();
        }
    }
}
