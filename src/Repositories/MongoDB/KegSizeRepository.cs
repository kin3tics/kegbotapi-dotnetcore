using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class KegSizeRepository : BaseMongoDBRepository, IRepository<KegSize>
    {
        private IMongoCollection<KegSize> KegSizes
        {
            get
            {
                return _db.GetCollection<KegSize>("KegSizes");
            }
        }
        KegSize IRepository<KegSize>.Create(KegSize item)
        {
            item.id = Guid.NewGuid().ToString();
            KegSizes.InsertOne(item);
            return item;
        }

        string IRepository<KegSize>.Delete(KegSize item)
        {
            KegSizes.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<KegSize> IRepository<KegSize>.GetAll()
        {
            var KegSizeList = KegSizes.Find(b => true).ToList();
            return KegSizeList;
        }

        KegSize IRepository<KegSize>.GetById(string id)
        {
            var KegSizeItem = KegSizes.Find(b => b.id == id).FirstOrDefault();
            return KegSizeItem;
        }

        KegSize IRepository<KegSize>.Update(KegSize item)
        {
            //UpdateOne if need performance
            KegSizes.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}