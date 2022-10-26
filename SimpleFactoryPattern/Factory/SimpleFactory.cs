using SimpleFactoryPattern.Concrete;
using SimpleFactoryPattern.Interface;

namespace SimpleFactoryPattern.Factory
{
    public class SimpleFactory
    {
        public static IProduct Make(string productType)
        {
            switch (productType)
            {
                case "A":
                    return new ConcreteProductA();
                case "B":
                    return new ConcreteProductB();
                case "C":
                    return new ConcreteProductC();
                default:
                    return null;
            }
        }
    }
}
