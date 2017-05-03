using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class TapRepository : BaseMongoDBRepository, IRepository<Tap>
    {
        private IMongoCollection<Tap> Taps
        {
            get
            {
                return _db.GetCollection<Tap>("Taps");
            }
        }
        Tap IRepository<Tap>.Create(Tap item)
        {
            item.id = Guid.NewGuid().ToString();
            Taps.InsertOne(item);
            return item;
        }

        string IRepository<Tap>.Delete(Tap item)
        {
            Taps.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<Tap> IRepository<Tap>.GetAll()
        {
            var TapList = Taps.Find(b => true).ToList();
            return TapList;
        }

        Tap IRepository<Tap>.GetById(string id)
        {
            var TapItem = Taps.Find(b => b.id == id).FirstOrDefault();
            return TapItem;
        }

        Tap IRepository<Tap>.Update(Tap item)
        {
            //UpdateOne if need performance
            Taps.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}