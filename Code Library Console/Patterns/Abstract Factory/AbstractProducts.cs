namespace Code_Library_Console.Patterns.Abstract_Factory
{
    // Абстрактный продукт 1
    public abstract class AbstractDataAccessor
    {
        public abstract void GetData();
    }

    // Абстрактный продукт 2
    public abstract class AbstractConnection
    {
        public abstract void OpenConnection();
    }
}
