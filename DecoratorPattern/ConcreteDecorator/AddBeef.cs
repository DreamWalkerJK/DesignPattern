using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class AddBeef : Garnish
    {
        public AddBeef(FastFood fastFood, double price, string desc) : base(fastFood, price, desc) { }

        public override double TotalCost()
        {
            return this.price + _fastFood.price;
        }
    }
}
