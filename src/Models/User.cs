namespace KegbotDotNetCore.API.Models
{
    public class User
    {
        public string username { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Image image { get; set; }
        public bool is_active { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string first_name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string last_name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string email { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string password { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public bool? is_staff { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public bool? is_superuser { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string last_login { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string date_joined { get; set; }
    }
}