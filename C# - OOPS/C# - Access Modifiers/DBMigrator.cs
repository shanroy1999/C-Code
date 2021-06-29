namespace C____Access_Modifiers
{
    public class DBMigrator{

        private readonly Logger _logger;

        // Create an association with the Logger Class -> define Parameter Logger
        public DBMigrator(Logger logger){
            _logger = logger;
        }

        public void Migrate(){
            _logger.Log("We are Migrating using Migrate method of DBMigrator");
        }
    }
}
