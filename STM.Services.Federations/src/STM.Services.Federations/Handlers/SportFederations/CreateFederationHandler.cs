using System.Threading.Tasks;
using Inspe.Common.Handlers;
using Inspe.Common.RabbitMq;
using STM.Services.Federations.Domain;
using STM.Services.Federations.Messages.Commands;
using STM.Services.Federations.Repositories;

namespace STM.Services.Federations.Handlers.SportFederations
{
    public class CreateFederationHandler : ICommandHandler<CreateFederation>
    {
        private readonly IFederationsRepository _federationsRepository;

        public CreateFederationHandler(IFederationsRepository federationsRepository)
        {
            _federationsRepository = federationsRepository;
        }

        public async Task HandleAsync(CreateFederation command, ICorrelationContext context)
        {
            var federation = new SportFederation(command.Id, command.Name);
            await _federationsRepository.AddAsync(federation);
        }
    }
}