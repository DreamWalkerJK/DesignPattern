namespace DecoratorPattern.Component
{
    public abstract class FastFood
    {
        public double price;
        public string desc;

        public FastFood(double price, string desc)
        {
            this.price = price;
            this.desc = desc;
        }

        public abstract double TotalCost();
    }
}
