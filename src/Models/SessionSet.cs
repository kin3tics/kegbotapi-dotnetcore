using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class SessionSet
    {
        public IEnumerable<Session> session { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}