using System;
using System.Collections.Generic;
using System.Linq;
using KegbotDotNetCore.API.Models;
using KegbotDotNetCore.API.Repositories.MongoDB;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class PoursController : Controller
    {
        protected PourEventRepository _PoursRepository;
        public PoursController() {
            _PoursRepository = new PourEventRepository();
        }

        [HttpGet]
        public IEnumerable<PourEvent> Get(string start)
        {
            var pours = _PoursRepository.GetAll()
                                        .Where(p => DateTime.Parse(p.time_utc) >= DateTime.Parse(start));
            return pours;
        }

        [HttpPut]
        [ProducesResponseType(typeof(PourEvent), 200)]
        public PourEvent Create(PourEvent pour)
        {
            return _PoursRepository.Create(pour);
        }

        [HttpPost]
        [ProducesResponseType(typeof(PourEvent), 200)]
        public PourEvent Update(PourEvent pour)
        {
            return _PoursRepository.Update(pour);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(PourEvent), 200)]
        public string Delete(PourEvent pour)
        {
            return _PoursRepository.Delete(pour);
        }

        [HttpGet]
        [Route("{id}")]
        public PourEvent GetById(string id)
        {
            return _PoursRepository.GetById(id);
        }
    }
}