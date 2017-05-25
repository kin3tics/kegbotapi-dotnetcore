using System.Collections.Generic;
using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;
using KegbotDotNetCore.API.Repositories.MongoDB;
using System.Linq;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class KegSizesController : Controller
    {
        protected KegSizeRepository _KegSizeRepository;
        protected PourEventRepository _PoursRepository;
        public KegSizesController() {
            _KegSizeRepository = new KegSizeRepository();
            _PoursRepository = new PourEventRepository();
        }
        
        [HttpGet]
        /// <response code="200">Successfully get List of KegSizes</response>
        [ProducesResponseType(typeof(IEnumerable<KegSize>), 200)]
        public IEnumerable<KegSize> Get()
        {
            return _KegSizeRepository.GetAll();
        }

        [HttpPut]
        [ProducesResponseType(typeof(KegSize), 200)]
        public KegSize Create(KegSize kegSize)
        {
            return _KegSizeRepository.Create(kegSize);
        }

        [HttpPost]
        [ProducesResponseType(typeof(KegSize), 200)]
        public KegSize Update(KegSize kegSize)
        {
            return _KegSizeRepository.Update(kegSize);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(KegSize), 200)]
        public string Delete(KegSize kegSize)
        {
            return _KegSizeRepository.Delete(kegSize);
        }

        [HttpGet]
        [Route("{id}")]
        public KegSize GetById (string id) 
        {
            return _KegSizeRepository.GetById(id);
        }
    }
}