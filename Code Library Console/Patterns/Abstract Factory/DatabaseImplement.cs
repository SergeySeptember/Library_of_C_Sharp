namespace Code_Library_Console.Patterns.Abstract_Factory
{
    // Конкретный продукт 1 для Database
    public class DBDataAccessor : AbstractDataAccessor
    {
        public override void GetData()
        {
            Console.WriteLine("Получение данных из базы данных...");
        }
    }

    // Конкретный продукт 2 для Database
    public class DBConnection : AbstractConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Открытие соединения с базой данных...");
        }
    }
}
