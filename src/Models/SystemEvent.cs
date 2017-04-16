namespace KegbotDotNetCore.API.Models
{
    public class SystemEvent
    {
        public string id { get; set; }
        public string kind { get; set; }
        public string time { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string drink_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string keg_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string session_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string user_id { get; set; }
    }
}