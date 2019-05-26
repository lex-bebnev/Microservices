using System.Threading.Tasks;
using Autofac;
using Inspe.Common.Handlers;
using Inspe.Common.Messages;
using Inspe.Common.RabbitMq;

namespace Inspe.Common.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext _context;

        public CommandDispatcher(IComponentContext context)
        {
            _context = context;
        }

        public async Task SendAsync<T>(T command) where T : ICommand
            => await _context.Resolve<ICommandHandler<T>>().HandleAsync(command, CorrelationContext.Empty);
    }
}