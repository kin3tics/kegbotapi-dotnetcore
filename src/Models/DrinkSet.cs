using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class DrinkSet
    {
        public IEnumerable<Drink> drinks { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}