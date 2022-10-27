using StrategyPattern.Strategy;

namespace StrategyPattern.Context
{
    public class Food
    {
        private Handling _handling;

        public Food(Handling handling)
        {
            this._handling = handling;
        }

        public void HandleFood()
        {
            _handling.Operating();
        }
    }
}
