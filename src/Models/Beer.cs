namespace KegbotDotNetCore.API.Models
{
    public class Beer
    {
        public string id { get; set; }
        public string beerDbId { get; set; }
        public string breweryId { get; set; }
        public virtual Brewery brewery { get; set; }
        public string imageId { get; set; }
        public virtual Image image { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string glassware { get; set; }
        public string style { get; set; }
        public decimal? abv { get; set; }
        public int? ibu { get; set; } 
    }
}