using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;
using KegbotDotNetCore.API.Repositories.MongoDB;
using System.Linq;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class BeersController : Controller
    {
        protected BeerRepository _BeerRepository;
        public BeersController() {
            _BeerRepository = new BeerRepository();
        }
        
        [HttpGet]
        /// <response code="200">Successfully get List of Kegs</response>
        [ProducesResponseType(typeof(IEnumerable<Beer>), 200)]
        public IEnumerable<Beer> Get()
        {
            return _BeerRepository.GetAll();
        }

        [HttpPut]
        [ProducesResponseType(typeof(Beer), 200)]
        public Beer Create(Beer beer)
        {
            return _BeerRepository.Create(beer);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Beer), 200)]
        public Beer Update(Beer beer)
        {
            return _BeerRepository.Update(beer);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Beer), 200)]
        public string Delete(Beer beer)
        {
            return _BeerRepository.Delete(beer);
        }

        [HttpGet]
        [Route("{id}")]
        public Beer GetById (string id) 
        {
            return _BeerRepository.GetById(id);
        }
    }
}