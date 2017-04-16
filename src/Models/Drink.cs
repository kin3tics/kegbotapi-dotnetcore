namespace KegbotDotNetCore.API.Models
{
    public class Drink
    {
        public string id { get; set; }
        public int ticks { get; set; }
        public double volume_ml { get; set; }
        public string session_id { get; set; }
        /// <summary>
        /// Timestamp in ISO8061 UTC
        /// </summary>
        public string pour_time { get; set; }
        /// <summary>
        /// (optional) Time in seconds
        /// </summary>
        public int? duration { get; set; }
        public string status { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public string keg_id { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public string user_id { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public string auth_token_id { get; set; }
    }
}