using System.Threading.Tasks;
using Inspe.Common.Messages;
using Inspe.Common.RabbitMq;

namespace Inspe.Common.Handlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command, ICorrelationContext context);
    }
}