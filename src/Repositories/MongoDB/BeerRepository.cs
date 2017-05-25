using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BeerRepository : BaseMongoDBRepository, IRepository<Beer>
    {
        public Beer Create(Beer item)
        {
            item.id = Guid.NewGuid().ToString();
            item.brewery = null;
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
            beerList = AttachEntities(beerList).ToList();
            return beerList;
        }

        public Beer GetById(string id)
        {
            var beerItem = Beers.Find(b => b.id == id).FirstOrDefault();
            beerItem = AttachEntities(beerItem);
            return beerItem;
        }

        public Beer Update(Beer item)
        {
            //UpdateOne if need performance
            item.brewery = null;
            Beers.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}