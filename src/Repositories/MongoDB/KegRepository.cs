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
        Keg IRepository<Keg>.Create(Keg item)
        {
            item.id = Guid.NewGuid().ToString();
            Kegs.InsertOne(item);
            return item;
        }

        string IRepository<Keg>.Delete(Keg item)
        {
            Kegs.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<Keg> IRepository<Keg>.GetAll()
        {
            var KegList = Kegs.Find(b => true).ToList();
            return KegList;
        }

        Keg IRepository<Keg>.GetById(string id)
        {
            var KegItem = Kegs.Find(b => b.id == id).FirstOrDefault();
            return KegItem;
        }

        Keg IRepository<Keg>.Update(Keg item)
        {
            //UpdateOne if need performance
            Kegs.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}