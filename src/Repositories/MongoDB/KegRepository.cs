using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class KegRepository : BaseMongoDBRepository, IRepository<Keg>
    {
        private IMongoCollection<Keg> Kegs
        {
            get
            {
                return _db.GetCollection<Keg>("Kegs");
            }
        }
        public Keg Create(Keg item)
        {
            item.id = Guid.NewGuid().ToString();
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
            return KegList;
        }

        public Keg GetById(string id)
        {
            var KegItem = Kegs.Find(b => b.id == id).FirstOrDefault();
            return KegItem;
        }

        public Keg Update(Keg item)
        {
            //UpdateOne if need performance
            Kegs.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}