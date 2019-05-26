using System.Threading.Tasks;
using Inspe.Common.Mvc;
using Inspe.Common.RabbitMq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenTracing;
using STM.Api.Messages.Commands.Federations;
using STM.Api.Query;
using STM.Api.Services;

namespace STM.Api.Controllers
{
    [AllowAnonymous]
    public class SportsFederationController: BaseController
    {
        private readonly ISportsFederationService _federationService;
        
        public SportsFederationController(IBusPublisher busPublisher, ITracer tracer)
            : base(busPublisher, tracer)
        {
            // _federationService = federationService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] BrowseSportsFederations query) 
            => Collection(await _federationService.BrowseAsync(query));

        [HttpPost]
        public async Task<IActionResult> Post(CreateFederation command)
            => await SendAsync(command.BindId(c => c.Id), resourceId: command.Id,
                resource: "federations");

    }
}