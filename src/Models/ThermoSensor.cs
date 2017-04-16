namespace KegbotDotNetCore.API.Models
{
    public class ThermoSensor 
    {
        public string id { get; set; }
        public string sensor_name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string nice_name { get; set; }
    }
}