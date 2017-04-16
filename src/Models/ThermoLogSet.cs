using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class ThermoLogSet
    {
        public IEnumerable<ThermoLog> logs { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}