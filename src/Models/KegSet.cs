using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class KegSet
    {
        public IEnumerable<Keg> kegs { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}