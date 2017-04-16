using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class TapDetailSet
    {
        public IEnumerable<TapDetail> taps { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}