using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class PourEventRepository : BaseMongoDBRepository, IRepository<PourEvent>
    {
        private IMongoCollection<PourEvent> PourEvents
        {
            get
            {
                return _db.GetCollection<PourEvent>("PourEvents");
            }
        }
        public PourEvent Create(PourEvent item)
        {
            item.id = Guid.NewGuid().ToString();
            item.tap = null;
            item.keg = null;
            PourEvents.InsertOne(item);
            return item;
        }

        public string Delete(PourEvent item)
        {
            PourEvents.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<PourEvent> GetAll()
        {
            var PourEventList = PourEvents.Find(b => true).ToList();
            PourEventList = AttachEntities(PourEventList).ToList();
            return PourEventList;
        }

        public PourEvent GetById(string id)
        {
            var PourEventItem = PourEvents.Find(b => b.id == id).FirstOrDefault();
            PourEventItem = AttachEntities(PourEventItem);
            return PourEventItem;
        }

        public IEnumerable<PourEvent> GetByIds(ICollection<string> ids) {
            var pourEventList = PourEvents.Find(b => ids.Contains(b.id)).ToList();

            return pourEventList;
        }

        public PourEvent Update(PourEvent item)
        {
            item.keg = null;
            item.tap = null;
            //UpdateOne if need performance
            PourEvents.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}