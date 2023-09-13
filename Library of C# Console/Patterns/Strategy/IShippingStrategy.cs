using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_C__Console.Patterns.Strategy
{
    public interface IShippingStrategy
    {
        double CalculateShippingCoast (double orderTotal);
    }
}
