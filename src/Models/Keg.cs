namespace KegbotDotNetCore.API.Models
{
    public class Keg
    {
        public string id { get; set; }
        public string type_id { get; set; }
        public string size_id { get; set; }
        public string size_name { get; set; }
        public decimal? size_volume_ml { get; set; }
        public decimal volume_ml_remain { get; set; }
        public decimal percent_full { get; set; }
        public string started_time { get; set; }
        public string finished_time { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public decimal? spilled_ml { get; set; }
    }
}