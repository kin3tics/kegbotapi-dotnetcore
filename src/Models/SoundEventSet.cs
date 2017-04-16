using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class SoundEventSet
    {
        public IEnumerable<SoundEvent> events { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}