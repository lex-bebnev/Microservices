using System.Threading.Tasks;
using Inspe.Common.Messages;
using Inspe.Common.RabbitMq;

namespace Inspe.Common.Handlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, ICorrelationContext context);
    }
}