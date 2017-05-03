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
        Beer IRepository<Beer>.Create(Beer item)
        {
            item.id = Guid.NewGuid().ToString();
            Beers.InsertOne(item);
            return item;
        }

        string IRepository<Beer>.Delete(Beer item)
        {
            Beers.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<Beer> IRepository<Beer>.GetAll()
        {
            var beerList = Beers.Find(b => true).ToList();
            return beerList;
        }

        Beer IRepository<Beer>.GetById(string id)
        {
            var beerItem = Beers.Find(b => b.id == id).FirstOrDefault();
            return beerItem;
        }

        Beer IRepository<Beer>.Update(Beer item)
        {
            //UpdateOne if need performance
            Beers.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}