namespace Code_Library_Console.Patterns.Strategy
{
    public interface IShippingStrategy
    {
        double CalculateShippingCoast(double orderTotal);
    }
}
