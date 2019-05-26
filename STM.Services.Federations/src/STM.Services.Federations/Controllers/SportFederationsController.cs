using System.Threading.Tasks;
using Inspe.Common.Dispatchers;
using Inspe.Common.Mvc;
using Microsoft.AspNetCore.Mvc;
using STM.Services.Federations.Messages.Commands;

namespace STM.Services.Federations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FederationsController : ControllerBase
    {
        private IDispatcher _dispatcher;

        public FederationsController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateFederation command)
        {
            await _dispatcher.SendAsync(command.BindId(c => c.Id));

            return Accepted();
        }
    }
}