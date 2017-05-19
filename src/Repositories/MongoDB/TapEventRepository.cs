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
        public TapEvent Create(TapEvent item)
        {
            item.id = Guid.NewGuid().ToString();
            TapEvents.InsertOne(item);
            return item;
        }

        public string Delete(TapEvent item)
        {
            TapEvents.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<TapEvent> GetAll()
        {
            var TapEventList = TapEvents.Find(b => true).ToList();
            return TapEventList;
        }

        public TapEvent GetById(string id)
        {
            var TapEventItem = TapEvents.Find(b => b.id == id).FirstOrDefault();
            return TapEventItem;
        }

        public TapEvent Update(TapEvent item)
        {
            //UpdateOne if need performance
            TapEvents.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}