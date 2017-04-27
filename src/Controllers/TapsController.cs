using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class TapsController : Controller
    {
        [HttpGet]
        public IEnumerable<Tap> Get(string start)
        {
            return new List<Tap>();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Tap GetById(string id)
        {
            return new Tap();
        }

        [HttpPost]
        [Route("api/[controller]/{id}")]
        public PourEvent RecordDrink(PourEvent pourEvent)
        {
            return pourEvent;
        }

        [HttpGet]
        [Route("api/[controller]/{id}/pours")]
        public IEnumerable<PourEvent> GetPoursByTapId (string id) 
        {
            return new List<PourEvent>();
        }
    }
}