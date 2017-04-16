namespace KegbotDotNetCore.API.Models
{
    ///But...Why?
    public class UserProfile
    {
        public string username { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string gender { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? weight { get; set; }
    }
}