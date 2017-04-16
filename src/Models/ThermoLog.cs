namespace KegbotDotNetCore.API.Models
{
    public class ThermoLog
    {
        public string id { get; set; }
        public string sensor_id { get; set; }
        public decimal temperature_c { get; set; }
        public string record_time { get; set; }
    }
}