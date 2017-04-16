using KegbotDotNetCore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KegbotDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthTokensController : Controller
    {
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public AuthenticationToken GetById(string id)
        {
            return new AuthenticationToken();
        }
    }
}