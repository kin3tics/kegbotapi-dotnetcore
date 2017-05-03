namespace KegbotDotNetCore.API.Models
{
    public class Image
    {
        public string id { get; set; }
        public string url { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public int? width { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public int? height { get; set; }
    }
}