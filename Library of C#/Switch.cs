namespace Library_of_C_
{
    public class Switch
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public static double DoOperation(double x, double y, Operation op)
        {
            double result = op switch
            {
                Operation.Add => x + y,
                Operation.Subtract => x - y,
                Operation.Multiply => x * y,
                Operation.Divide => x / y
            };
            return result;
        }

        


    }
}
