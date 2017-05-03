using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class TapEventRepository : BaseMongoDBRepository, IRepository<TapEvent>
    {
        private IMongoCollection<TapEvent> TapEvents
        {
            get
            {
                return _db.GetCollection<TapEvent>("TapEvents");
            }
        }
        TapEvent IRepository<TapEvent>.Create(TapEvent item)
        {
            item.id = Guid.NewGuid().ToString();
            TapEvents.InsertOne(item);
            return item;
        }

        string IRepository<TapEvent>.Delete(TapEvent item)
        {
            TapEvents.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<TapEvent> IRepository<TapEvent>.GetAll()
        {
            var TapEventList = TapEvents.Find(b => true).ToList();
            return TapEventList;
        }

        TapEvent IRepository<TapEvent>.GetById(string id)
        {
            var TapEventItem = TapEvents.Find(b => b.id == id).FirstOrDefault();
            return TapEventItem;
        }

        TapEvent IRepository<TapEvent>.Update(TapEvent item)
        {
            //UpdateOne if need performance
            TapEvents.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}