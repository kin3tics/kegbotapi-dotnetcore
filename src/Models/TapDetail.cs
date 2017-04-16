namespace KegbotDotNetCore.API.Models
{
    public class TapDetail
    {
        public KegTap tap { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Keg keg { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public BeerType beer_type { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Brewer brewer { get; set; }
    }
}