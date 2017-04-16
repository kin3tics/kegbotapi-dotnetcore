using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class SystemEventSet
    {
        public IEnumerable<SystemEvent> events { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}