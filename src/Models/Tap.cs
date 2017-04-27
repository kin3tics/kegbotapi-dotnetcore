namespace KegbotDotNetCore.API.Models
{
    public class Tap
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string current_keg_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
    }
}