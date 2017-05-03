using System;
using KegbotDotNetCore.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories.MongoDB
{
    public class ImageRepository : BaseMongoDBRepository, IRepository<Image>
    {
        private IMongoCollection<Image> Images
        {
            get
            {
                return _db.GetCollection<Image>("Images");
            }
        }
        Image IRepository<Image>.Create(Image item)
        {
            item.id = Guid.NewGuid().ToString();
            Images.InsertOne(item);
            return item;
        }

        string IRepository<Image>.Delete(Image item)
        {
            Images.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        IEnumerable<Image> IRepository<Image>.GetAll()
        {
            var ImageList = Images.Find(b => true).ToList();
            return ImageList;
        }

        Image IRepository<Image>.GetById(string id)
        {
            var ImageItem = Images.Find(b => b.id == id).FirstOrDefault();
            return ImageItem;
        }

        Image IRepository<Image>.Update(Image item)
        {
            //UpdateOne if need performance
            Images.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}