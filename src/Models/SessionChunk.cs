namespace KegbotDotNetCore.API.Models
{
    public class SessionChunk
    {
        public string id { get; set; }
        public string session_id { get; set; }
        public string username { get; set; }
        public string keg_id { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public decimal volume_ml { get; set; }
    }
}