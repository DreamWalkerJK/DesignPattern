using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class FiredRice : FastFood
    {
        public FiredRice(double price, string desc) : base(price, desc) { }

        public override double TotalCost()
        {
            return this.price;
        }
    }
}
