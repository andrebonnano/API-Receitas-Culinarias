
namespace Infra
{
    class Context
    {
        public const string dbName = "apiculinaria";
        public const string dbUser = "andrebonnano";
        public const string dbPassword = "maride2006";
        public const string connectionString = $"mongodb+srv://{dbUser}:{dbPassword}@db-api-culinaria.kw4dnaa.mongodb.net/?retryWrites=true&w=majority";

        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public Context()
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(dbName);
        }

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoCollection<Recipe> Recipes
        {
            get { return _database.GetCollection<Recipe>("recipes"); }
        }

        public IMongoCollection<User> Users
        {
            get { return _database.GetCollection<User>("users"); }
        }

        public IMongoCollection<Category> Categories
        {
            get { return _database.GetCollection<Category>("categories"); }
        }
    }
}
