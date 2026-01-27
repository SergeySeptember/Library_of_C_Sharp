namespace Code_Library_Console.Patterns.Abstract_Factory
{
    public abstract class AbstractDataAccessorFactory
    {
        public abstract AbstractDataAccessor CreateDataAccessor();
        public abstract AbstractConnection CreateConnection();
    }

    // Конкретная фабрика для WebService
    public class WebServiceDataAccessorFactory : AbstractDataAccessorFactory
    {
        public override AbstractDataAccessor CreateDataAccessor()
        {
            return new WebServiceDataAccessor();
        }

        public override AbstractConnection CreateConnection()
        {
            return new WebServiceConnection();
        }
    }

    // Конкретная фабрика для Database
    public class DatabaseDataAccessorFactory : AbstractDataAccessorFactory
    {
        public override AbstractDataAccessor CreateDataAccessor()
        {
            return new DBDataAccessor();
        }

        public override AbstractConnection CreateConnection()
        {
            return new DBConnection();
        }
    }

    /*
     // Используем фабрику для веб-сервиса
        AbstractDataAccessorFactory webFactory = new WebServiceDataAccessorFactory();
        AbstractDataAccessor webDataAccessor = webFactory.CreateDataAccessor();
        AbstractConnection webConnection = webFactory.CreateConnection();
        
        webConnection.OpenConnection();
        webDataAccessor.GetData();

        Console.WriteLine();

        // Используем фабрику для базы данных
        AbstractDataAccessorFactory dbFactory = new DatabaseDataAccessorFactory();
        AbstractDataAccessor dbDataAccessor = dbFactory.CreateDataAccessor();
        AbstractConnection dbConnection = dbFactory.CreateConnection();

        dbConnection.OpenConnection();
        dbDataAccessor.GetData();
     */
}
