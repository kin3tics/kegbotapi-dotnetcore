using MongoDB.Driver;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BaseMongoDBRepository 
    {
        private IMongoClient _client;
        protected IMongoDatabase _db;
        public BaseMongoDBRepository() 
        {
            _client = new MongoClient();
            _db = _client.GetDatabase("keggy");
        }
    }
}