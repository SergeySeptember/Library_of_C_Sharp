namespace Code_Library_Console.Algorithms
{
    public class BalanceBracers
    {
        private static readonly Dictionary<char, char> Pairs = new()
        {
            { '{', '}' },
            { '(', ')' },
            { '[', ']' }
        };

        public static bool IsBalanced(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            Stack<char> stack = new();

            foreach (char symbol in text)
            {
                if (Pairs.ContainsKey(symbol))
                    stack.Push(symbol);
                else if (!Pairs.ContainsValue(symbol))
                    continue;
                else if (stack.Count == 0)
                    return false;
                else if (Pairs[stack.Pop()] != symbol)
                    return false;
            }

            return stack.Count == 0;
        }
        /* Примеры для запуска
        Console.WriteLine(IsBalanced("()[][{}]")); // true
        Console.WriteLine(IsBalanced("[}")); // false
        Console.WriteLine(IsBalanced("})[]{}")); // false
        Console.WriteLine(IsBalanced("(}")); // false
        Console.WriteLine(IsBalanced("({https://t.me/platinum_tech_talks})")); // true!
        Console.WriteLine(IsBalanced("({}a)")); // true
        */
    }
}
