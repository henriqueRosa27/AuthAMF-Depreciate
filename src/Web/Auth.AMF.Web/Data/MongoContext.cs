using Auth.AMF.Web.Extensions;
using Auth.AMF.Web.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Auth.AMF.Web.Data
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;


        public MongoContext(IOptions<AppSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.MongoConnection.ConnectionString);
            _database = mongoClient.GetDatabase(options.Value.MongoConnection.Database);
        }

        public IMongoCollection<CreatePassword> CreatePassword
        {
            get
            {
                return _database.GetCollection<CreatePassword>("CreatePassword");
            }
        }
    }
}
