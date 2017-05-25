namespace KegbotDotNetCore.API.Models
{
    public class PourEvent
    {
        public string id { get; set; }
        public string time_utc { get; set; }
        public decimal pourAmount_ml { get; set; }
        public string tapId { get; set; }
        public virtual Tap tap { get; set; }
        public string kegId { get; set; }
        public virtual Keg keg { get; set; }
        public string description { get; set; }
    }
}