namespace Code_Library_Console.Patterns.Strategy
{
    public class ShoppingCart
    {
        private readonly IShippingStrategy _shippingStrategy;

        public ShoppingCart(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateTotalPrice(double orderTotal)
        {
            double shippingCoast = _shippingStrategy.CalculateShippingCoast(orderTotal);
            return orderTotal + shippingCoast;
        }
    }
}
