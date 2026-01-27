namespace Code_Library_Console.Patterns.Observer
{
    public class Subject
    {
        private List<IObserver> _observers = new();
        private string _state;

        public string State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }
}