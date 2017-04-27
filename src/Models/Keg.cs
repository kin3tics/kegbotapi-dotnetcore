namespace KegbotDotNetCore.API.Models
{
    public class Keg
    {
        public string id { get; set; }
        public KegSize kegSize { get; set; }
        public Beer beer { get; set; }
        public decimal volume_ml_remain { get; set; }
        public decimal percent_full { get; set; }
        public string started_time { get; set; }
        public string finished_time { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public decimal? spilled_ml { get; set; }
    }
}