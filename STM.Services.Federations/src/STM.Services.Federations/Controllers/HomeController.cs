using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace STM.Services.Federations.Controllers
{
    [Route("")]
    public class HomeController: ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get() => Ok("STM Federations service");
    }
}