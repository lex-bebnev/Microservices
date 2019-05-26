using System;
using Inspe.Common.Messages;
using Inspe.Common.Types;

namespace Inspe.Common.RabbitMq
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeCommand<TCommand>(string @namespace = null, string queueName = null,
            Func<TCommand, InspeException, IRejectedEvent> onError = null)
            where TCommand : ICommand;

        IBusSubscriber SubscribeEvent<TEvent>(string @namespace = null, string queueName = null,
            Func<TEvent, InspeException, IRejectedEvent> onError = null) 
            where TEvent : IEvent;
    }
}
