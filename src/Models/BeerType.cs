namespace KegbotDotNetCore.API.Models
{
    public class BeerType
    {
        public string id { get; set; }
        public string name { get; set; }
        public string brewer_id { get; set; }
        public string style_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string edition { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? abv { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? calories_oz { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? carbs_oz { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? specific_gravity { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? original_gravity { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Image image { get; set; }
    }
}