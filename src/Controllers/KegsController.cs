using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class KegsController : Controller
    {
        
        [HttpGet]
        /// <response code="200">Successfully get List of Kegs</response>
        [ProducesResponseType(typeof(IEnumerable<Keg>), 200)]
        public IEnumerable<Keg> Get()
        {
            return new List<Keg>();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public JsonResult GetById (string id) 
        {
            return new JsonResult( new {
                keg = new Keg(),
                type = new BeerType(),
                size = new KegSize(),
                drinks = new List<Drink>()
            });
        }

        [HttpGet]
        [Route("api/[controller]/{id}/drinks")]
        public List<Drink> GetDrinksById (string id) 
        {
            return new List<Drink>();
        }

        [HttpGet]
        [Route("api/[controller]/{id}/sessions")]
        public List<Session> GetSessionsById (string id) 
        {
            return new List<Session>();
        }
    }
}