using System.Security.Authentication;
using MongoDB.Driver;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BaseMongoDBRepository 
    {
        private IMongoClient _client;
        protected IMongoDatabase _db;
        public BaseMongoDBRepository() 
        {
            string connectionString = @"mongodb://kegbot-dotnetcore:vCd3SimxJl5bI6r0YBPYFnYa7OSrEFWsExs06H890I2SEXIVs0Ug3fCj3iaMdzcBNY7trJ2q2awdjOmERmuo0Q==@kegbot-dotnetcore.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            _client = new MongoClient(settings);
            _db = _client.GetDatabase("keggy");
        }
    }
}