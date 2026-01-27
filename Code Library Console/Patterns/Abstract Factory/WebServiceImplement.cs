namespace Code_Library_Console.Patterns.Abstract_Factory
{
    // Конкретный продукт 1 для WebService
    public class WebServiceDataAccessor : AbstractDataAccessor
    {
        public override void GetData()
        {
            Console.WriteLine("Получение данных из веб-сервиса...");
        }
    }

    // Конкретный продукт 2 для WebService
    public class WebServiceConnection : AbstractConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Установка соединения с веб-сервисом...");
        }
    }
}