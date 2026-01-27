namespace Code_Library_Console.Patterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name) => _name = name;

        void IObserver.Update(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
}