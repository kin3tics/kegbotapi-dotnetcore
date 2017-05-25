using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BreweryRepository : BaseMongoDBRepository, IRepository<Brewery>
    {
        public Brewery Create(Brewery item)
        {
            item.id = Guid.NewGuid().ToString();
            Breweries.InsertOne(item);
            return item;
        }

        public string Delete(Brewery item)
        {
            Breweries.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<Brewery> GetAll()
        {
            var BreweryList = Breweries.Find(b => true).ToList();
            return BreweryList;
        }

        public Brewery GetById(string id)
        {
            var BreweryItem = Breweries.Find(b => b.id == id).FirstOrDefault();
            return BreweryItem;
        }

        public Brewery Update(Brewery item)
        {
            //UpdateOne if need performance
            Breweries.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}