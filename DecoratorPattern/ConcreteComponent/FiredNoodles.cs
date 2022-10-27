using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class FiredNoodles : FastFood
    {
        public FiredNoodles(double price, string desc) : base(price, desc) { }

        public override double TotalCost()
        {
            return this.price;
        }
    }
}
