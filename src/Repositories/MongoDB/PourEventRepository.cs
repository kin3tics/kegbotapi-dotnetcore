using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class PourEventRepository : BaseMongoDBRepository, IRepository<PourEvent>
    {
        private IMongoCollection<PourEvent> PourEvents
        {
            get
            {
                return _db.GetCollection<PourEvent>("PourEvents");
            }
        }
        PourEvent IRepository<PourEvent>.Create(PourEvent item)
        {
            item.id = Guid.NewGuid().ToString();
            PourEvents.InsertOne(item);
            return item;
        }

        string IRepository<PourEvent>.Delete(PourEvent item)
        {
            PourEvents.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<PourEvent> IRepository<PourEvent>.GetAll()
        {
            var PourEventList = PourEvents.Find(b => true).ToList();
            return PourEventList;
        }

        PourEvent IRepository<PourEvent>.GetById(string id)
        {
            var PourEventItem = PourEvents.Find(b => b.id == id).FirstOrDefault();
            return PourEventItem;
        }

        PourEvent IRepository<PourEvent>.Update(PourEvent item)
        {
            //UpdateOne if need performance
            PourEvents.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}