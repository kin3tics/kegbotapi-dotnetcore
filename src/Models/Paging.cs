namespace KegbotDotNetCore.API.Models
{
    public class Paging
    {
        ///<summary>
        ///(optional)
        ///</summary>
        public int? total { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public int? limit { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public int? pos { get; set; }
    }
}