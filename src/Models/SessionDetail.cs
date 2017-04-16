using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class SessionDetail
    {
        public Session session { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string stats { get; set; }
        public IEnumerable<Keg> kegs { get; set; }
    }
}