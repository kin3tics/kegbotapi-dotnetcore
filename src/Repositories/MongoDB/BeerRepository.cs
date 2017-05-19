using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BeerRepository : BaseMongoDBRepository, IRepository<Beer>
    {
        private IMongoCollection<Beer> Beers
        {
            get
            {
                return _db.GetCollection<Beer>("Beers");
            }
        }
        public Beer Create(Beer item)
        {
            item.id = Guid.NewGuid().ToString();
            Beers.InsertOne(item);
            return item;
        }

        public string Delete(Beer item)
        {
            Beers.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<Beer> GetAll()
        {
            var beerList = Beers.Find(b => true).ToList();
            return beerList;
        }

        public Beer GetById(string id)
        {
            var beerItem = Beers.Find(b => b.id == id).FirstOrDefault();
            return beerItem;
        }

        public Beer Update(Beer item)
        {
            //UpdateOne if need performance
            Beers.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}