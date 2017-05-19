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
        public Image Create(Image item)
        {
            item.id = Guid.NewGuid().ToString();
            Images.InsertOne(item);
            return item;
        }

        public string Delete(Image item)
        {
            Images.DeleteOne(b => b.id == item.id);
            return item.id;
        }

        public IEnumerable<Image> GetAll()
        {
            var ImageList = Images.Find(b => true).ToList();
            return ImageList;
        }

        public Image GetById(string id)
        {
            var ImageItem = Images.Find(b => b.id == id).FirstOrDefault();
            return ImageItem;
        }

        public Image Update(Image item)
        {
            //UpdateOne if need performance
            Images.ReplaceOne(b => b.id == item.id, item);
            return item;
        }
    }
}