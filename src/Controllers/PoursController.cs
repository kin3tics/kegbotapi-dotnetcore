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

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public PourEvent GetById(string id)
        {
            return _PoursRepository.GetById(id);
        }
    }
}