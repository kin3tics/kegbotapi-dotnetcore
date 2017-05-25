using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;
using KegbotDotNetCore.API.Repositories.MongoDB;
using System.Linq;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class KegsController : Controller
    {
        protected KegRepository _KegRepository;
        protected PourEventRepository _PoursRepository;
        public KegsController() {
            _KegRepository = new KegRepository();
            _PoursRepository = new PourEventRepository();
        }
        
        [HttpGet]
        /// <response code="200">Successfully get List of Kegs</response>
        [ProducesResponseType(typeof(IEnumerable<Keg>), 200)]
        public IEnumerable<Keg> Get()
        {
            return _KegRepository.GetAll();
        }

        
        [HttpPut]
        [ProducesResponseType(typeof(Keg), 200)]
        public Keg Create(Keg keg)
        {
            return _KegRepository.Create(keg);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Keg), 200)]
        public Keg Update(Keg keg)
        {
            return _KegRepository.Update(keg);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Keg), 200)]
        public string Delete(Keg keg)
        {
            return _KegRepository.Delete(keg);
        }

        [HttpGet]
        [Route("{id}")]
        public Keg GetById (string id) 
        {
            return _KegRepository.GetById(id);
        }

        [HttpGet]
        [Route("{id}/pours")]
        public IEnumerable<PourEvent> GetPoursByKegId (string id) 
        {
            var pours = _PoursRepository.GetAll()
                                        .Where(p => p.keg.id == id);
            return pours;
        }
    }
}