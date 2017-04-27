namespace KegbotDotNetCore.API.Models
{
    public class TapEvent
    {
        public string id { get; set; }
        public string time_utc { get; set; }
        public Keg keg { get; set; }
        public string description { get; set; }
    }
}