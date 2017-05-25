using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class TapRepository : BaseMongoDBRepository, IRepository<Tap>
    {
        public Tap Create(Tap item)
        {
            item.id = Guid.NewGuid().ToString();
            item.current_keg = null;
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
            TapList = AttachEntities(TapList).ToList();
            return TapList;
        }

        public Tap GetById(string id)
        {
            var TapItem = Taps.Find(b => b.id == id).FirstOrDefault();
            TapItem = AttachEntities(TapItem);
            return TapItem;
        }

        public Tap Update(Tap item)
        {
            item.current_keg = null;
            //UpdateOne if need performance
            Taps.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }


}