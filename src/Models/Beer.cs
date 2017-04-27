namespace KegbotDotNetCore.API.Models
{
    public class Beer
    {
        public string id { get; set; }
        public string beerDbId { get; set; }
        public Brewery brewery { get; set; }
        public Image image { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string glassware { get; set; }
        public string style { get; set; }
        public decimal? abv { get; set; }
        public int? ibu { get; set; } 
    }
}