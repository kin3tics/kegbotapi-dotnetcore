namespace KegbotDotNetCore.API.Models
{
    public class Brewer
    {
        public string id { get; set; }
        public string name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string country { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string origin_state { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string origin_city { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string production { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string url { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string description { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Image image { get; set; }
    }
}