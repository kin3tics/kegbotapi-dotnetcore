using System.Collections.Generic;
using System.Linq;
using KegbotDotNetCore.API.Models;
using KegbotDotNetCore.API.Repositories.MongoDB;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class TapsController : Controller
    {
        protected TapRepository _TapRepository;
        protected PourEventRepository _PoursRepository;
        public TapsController()
        {
            _TapRepository = new TapRepository();
            _PoursRepository = new PourEventRepository();
        }

        [HttpGet]
        public IEnumerable<Tap> Get()
        {
            return _TapRepository.GetAll();
        }

        [HttpPut]
        [ProducesResponseType(typeof(Tap), 200)]
        public Tap Create(Tap tap)
        {
            return _TapRepository.Create(tap);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Tap), 200)]
        public Tap Update(Tap tap)
        {
            return _TapRepository.Update(tap);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Tap), 200)]
        public string Delete(Tap tap)
        {
            return _TapRepository.Delete(tap);
        }

        [HttpGet]
        [Route("{id}")]
        public Tap GetById(string id)
        {
            return _TapRepository.GetById(id);
        }

        [HttpPost]
        [Route("{id}")]
        public PourEvent RecordDrink(PourEvent pourEvent)
        {
            return _PoursRepository.Create(pourEvent);
        }

        [HttpGet]
        [Route("{id}/pours")]
        public IEnumerable<PourEvent> GetPoursByTapId (string id) 
        {
            var pours = _PoursRepository.GetAll()
                                        .Where(p => p.tap.id == id);
            return pours;
        }
    }
}