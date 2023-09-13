namespace Code_Library_Console.Patterns.Strategy
{
    public class StandartOrder : IShippingStrategy
    {
        public double CalculateShippingCoast(double orderTotal)
        {
            return orderTotal * 0.1;
        }
    }
}
