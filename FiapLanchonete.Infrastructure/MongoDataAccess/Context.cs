using FiapLanchonete.Infrastructure.MongoDataAccess.Entities;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace FiapLanchonete.Infrastructure.MongoDataAccess
{
    public class Context
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase database;

        public Context(string connectionString, string databaseName)
        {
            this.mongoClient = new MongoClient(connectionString);
            this.database = mongoClient.GetDatabase(databaseName);
            Map();
        }

        public IMongoCollection<Order> Orders
        {
            get
            {
                return database.GetCollection<Order>("Orders");
            }
        }

        public IMongoCollection<Product> Products
        {
            get
            {
                return database.GetCollection<Product>("Products");
            }
        }

        private void Map()
        {
            BsonClassMap.RegisterClassMap<Order>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Product>(cm =>
            {
                cm.AutoMap();
            });
        }
    }
}
