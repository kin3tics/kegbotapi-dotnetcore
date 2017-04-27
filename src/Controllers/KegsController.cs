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
        public Keg GetById (string id) 
        {
            return new Keg();
        }

        [HttpGet]
        [Route("api/[controller]/{id}/pours")]
        public IEnumerable<PourEvent> GetPoursByKegId (string id) 
        {
            return new List<PourEvent>();
        }
    }
}