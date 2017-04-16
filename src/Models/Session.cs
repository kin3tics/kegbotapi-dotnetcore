namespace KegbotDotNetCore.API.Models
{
    public class Session
    {
        public string id { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public decimal volume_ml { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string slug { get; set; }
    }
}