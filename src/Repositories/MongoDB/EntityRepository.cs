///
/// Good Idea
///
/// Bad Idea
///
/*using System;
using System.Reflection;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class EntityRepository<T> : BaseMongoDBRepository, IRepository<T>
    {
        private IMongoCollection<T> Entities
        {
            get
            {
                var type = typeof(T).Name;
                return _db.GetCollection<T>(type);
            }
        }
        T IRepository<T>.Create(T item)
        {
            item.GetType()
                .GetProperty("id")
                .SetValue(item, Guid.NewGuid().ToString());
            Entities.InsertOne(item);
            return item;
        }

        string IRepository<T>.Delete(T item)
        {
            Entities.DeleteOne(b => b.GetType().GetProperty("id").GetValue(b) == item.GetType().GetProperty("id").GetValue(item));
            return item.;
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
} */