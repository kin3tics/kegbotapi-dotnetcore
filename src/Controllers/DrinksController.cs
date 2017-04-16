using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class DrinksController : Controller
    {
        [HttpGet]
        public DrinkSet Get(string start)
        {
            return new DrinkSet();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public JsonResult GetById(string id)
        {
            return new JsonResult( new {
                drink = new Drink(),
                keg = new Keg(),
                user = new User(),
                session = new Session()
            });
        }
    }
}