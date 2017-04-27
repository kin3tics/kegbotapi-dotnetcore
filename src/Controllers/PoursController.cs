using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class PoursController : Controller
    {
        [HttpGet]
        public IEnumerable<PourEvent> Get(string start)
        {
            return new List<PourEvent>();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public PourEvent GetById(string id)
        {
            return new PourEvent();
        }
    }
}