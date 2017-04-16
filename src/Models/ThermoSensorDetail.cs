namespace KegbotDotNetCore.API.Models
{
    public class ThermoSensorDetail
    {
        public ThermoSensor sensor { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public decimal? last_temp { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string last_time { get; set; }
    }
}