namespace KegbotDotNetCore.API.Models
{
    public class ThermoSummaryLog
    {
        public string id { get; set; }
        public string sensor_id { get; set; }
        public string date { get; set; }
        public string period { get; set; }
        public int num_readings { get; set; }
        public decimal min_temp { get; set; }
        public decimal max_temp { get; set; }
        public decimal mean_temp { get; set; }
    }
}