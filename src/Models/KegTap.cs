namespace KegbotDotNetCore.API.Models
{
    public class KegTap
    {
        public string id { get; set; }
        public string name { get; set; }
        public string meter_name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string relay_name { get; set; }
        public decimal ml_per_tick { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string description { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string current_keg_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string thermo_sensor_id { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public ThermoLog last_temperature { get; set; }
    }
}