namespace KegbotDotNetCore.API.Models
{
    public class AuthenticationToken
    {
        public string id { get; set; }
        public string auth_device { get; set; }
        public string token_value { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public string nice_name { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public bool? enabled { get; set; }
        /// <summary>
        /// (optional) Timestamp in ISO8061 UTC
        /// </summary>
        public string created_time { get; set; }
        /// <summary>
        /// (optional) Timestamp in ISO8061 UTC
        /// </summary>
        public string expire_time { get; set; }
        /// <summary>
        /// (optional)
        /// </summary>
        public string pin { get; set; }
    }
}