using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class SystemEventDetailSet
    {
        public IEnumerable<SystemEventDetail> events { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}