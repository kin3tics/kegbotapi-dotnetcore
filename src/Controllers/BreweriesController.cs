using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;
using KegbotDotNetCore.API.Repositories.MongoDB;
using System.Linq;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class BreweriesController : Controller
    {
        protected BreweryRepository _BreweryRepository;
        public BreweriesController() {
            _BreweryRepository = new BreweryRepository();
        }
        
        [HttpGet]
        /// <response code="200">Successfully get List of Kegs</response>
        [ProducesResponseType(typeof(IEnumerable<Brewery>), 200)]
        public IEnumerable<Brewery> Get()
        {
            return _BreweryRepository.GetAll();
        }

        [HttpPut]
        [ProducesResponseType(typeof(Brewery), 200)]
        public Brewery Create(Brewery bewery)
        {
            return _BreweryRepository.Create(bewery);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Brewery), 200)]
        public Brewery Update(Brewery bewery)
        {
            return _BreweryRepository.Update(bewery);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Brewery), 200)]
        public string Delete(Brewery bewery)
        {
            return _BreweryRepository.Delete(bewery);
        }

        [HttpGet]
        [Route("{id}")]
        public Brewery GetById (string id) 
        {
            return _BreweryRepository.GetById(id);
        }
    }
}