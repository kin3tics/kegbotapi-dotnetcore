using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class BreweryRepository : BaseMongoDBRepository, IRepository<Brewery>
    {
        private IMongoCollection<Brewery> Breweries
        {
            get
            {
                return _db.GetCollection<Brewery>("Breweries");
            }
        }
        Brewery IRepository<Brewery>.Create(Brewery item)
        {
            item.id = Guid.NewGuid().ToString();
            Breweries.InsertOne(item);
            return item;
        }

        string IRepository<Brewery>.Delete(Brewery item)
        {
            Breweries.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<Brewery> IRepository<Brewery>.GetAll()
        {
            var BreweryList = Breweries.Find(b => true).ToList();
            return BreweryList;
        }

        Brewery IRepository<Brewery>.GetById(string id)
        {
            var BreweryItem = Breweries.Find(b => b.id == id).FirstOrDefault();
            return BreweryItem;
        }

        Brewery IRepository<Brewery>.Update(Brewery item)
        {
            //UpdateOne if need performance
            Breweries.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}