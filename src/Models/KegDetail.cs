using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class KegDetail
    {
        public Keg keg { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public BeerType type { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public KegSize size { get; set; }
        public IEnumerable<Drink> drinks { get; set; }
        public IEnumerable<Session> sessions { get; set; }
    }
}