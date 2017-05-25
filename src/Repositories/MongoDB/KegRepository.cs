using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class KegRepository : BaseMongoDBRepository, IRepository<Keg>
    {
        public Keg Create(Keg item)
        {
            item.id = Guid.NewGuid().ToString();
            item.kegSize = null;
            item.beer = null;
            Kegs.InsertOne(item);
            return item;
        }

        public string Delete(Keg item)
        {
            Kegs.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<Keg> GetAll()
        {
            var KegList = Kegs.Find(b => true).ToList();
            KegList = AttachEntities(KegList).ToList();
            return KegList;
        }

        public Keg GetById(string id)
        {
            var KegItem = Kegs.Find(b => b.id == id).FirstOrDefault();
            KegItem = AttachEntities(KegItem);
            return KegItem;
        }

        public Keg Update(Keg item)
        {
            item.beer = null;
            item.kegSize = null;
            //UpdateOne if need performance
            Kegs.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}