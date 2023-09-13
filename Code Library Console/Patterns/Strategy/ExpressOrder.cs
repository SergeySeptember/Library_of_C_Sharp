namespace Code_Library_Console.Patterns.Strategy
{
    public class ExpressOrder : IShippingStrategy
    {
        public double CalculateShippingCoast(double orderTotal)
        {
            return orderTotal * 0.2;
        }
    }
}
