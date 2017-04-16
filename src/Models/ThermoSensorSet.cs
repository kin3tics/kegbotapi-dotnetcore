using System.Collections.Generic;

namespace KegbotDotNetCore.API.Models
{
    public class ThermoSensorSet
    {
        public IEnumerable<ThermoSensor> sensors { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public Paging paging { get; set; }
    }
}