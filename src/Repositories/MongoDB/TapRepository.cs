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
        public Tap Create(Tap item)
        {
            item.id = Guid.NewGuid().ToString();
            Taps.InsertOne(item);
            return item;
        }

        public string Delete(Tap item)
        {
            Taps.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<Tap> GetAll()
        {
            var TapList = Taps.Find(b => true).ToList();
            return TapList;
        }

        public Tap GetById(string id)
        {
            var TapItem = Taps.Find(b => b.id == id).FirstOrDefault();
            return TapItem;
        }

        public Tap Update(Tap item)
        {
            //UpdateOne if need performance
            Taps.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}