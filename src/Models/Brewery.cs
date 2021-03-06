namespace KegbotDotNetCore.API.Models
{
    public class Brewery
    {
        public string id { get; set; }
        public string beerDbId { get; set; }
        public string imageId { get; set; }
        public virtual Image image { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string website { get; set; }

    }
}