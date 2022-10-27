using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class Garnish : FastFood
    {
        protected FastFood _fastFood;

        public Garnish(FastFood fastFood, double price, string desc) : base(price, desc) 
        {
            this._fastFood = fastFood;
            this.desc = fastFood.desc + base.desc;
        }
    }
}
