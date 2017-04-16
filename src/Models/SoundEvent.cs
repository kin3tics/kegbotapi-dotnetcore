namespace KegbotDotNetCore.API.Models
{
    public class SoundEvent
    {
        public string event_name { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string event_predicate { get; set; }
        public string sound_url { get; set; }
        ///<summary>
        ///(optional)
        ///</summary>
        public string user { get; set; }
    }
}