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

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Tap GetById(string id)
        {
            return _TapRepository.GetById(id);
        }

        [HttpPost]
        [Route("api/[controller]/{id}")]
        public PourEvent RecordDrink(PourEvent pourEvent)
        {
            return _PoursRepository.Create(pourEvent);
        }

        [HttpGet]
        [Route("api/[controller]/{id}/pours")]
        public IEnumerable<PourEvent> GetPoursByTapId (string id) 
        {
            var pours = _PoursRepository.GetAll()
                                        .Where(p => p.tap.id == id);
            return pours;
        }
    }
}