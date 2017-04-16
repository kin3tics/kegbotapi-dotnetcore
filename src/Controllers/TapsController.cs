using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class TapsController : Controller
    {
        [HttpGet]
        public JsonResult Get(string start)
        {
            return new JsonResult( new {
                taps = new List<object> { 
                    new {
                        tap = new KegTap(),
                        keg = new Keg(),
                        beverage = new BeerType()
                    }
                }
            });
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public JsonResult GetById(string id)
        {
            return new JsonResult( new {
                tap = new KegTap(),
                keg = new Keg()
            });
        }

        [HttpPost]
        [Route("api/[controller]/{id}")]
        public JsonResult RecordDrink(string id, int ticks, decimal? volume_ml, string username, int? pour_time, int? now, int? duration, string auth_token, bool? spilled)
        {
            return new JsonResult( new {
                drink = new Drink(),
                keg = new Keg(),
                user = new User(),
                session = new Session()
            });
        }
    }
}