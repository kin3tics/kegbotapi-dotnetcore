using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ThermoSensorController : Controller
    {
        [HttpPost]
        [Route("api/[controller]/{id}")]
        public ThermoSensor RecordTemperature(string id, decimal temp_c)
        {
            return new ThermoSensor();
        }
    }
}