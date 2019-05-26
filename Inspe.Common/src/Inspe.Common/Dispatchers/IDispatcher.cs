using System.Threading.Tasks;
using Inspe.Common.Messages;
using Inspe.Common.Types;

namespace Inspe.Common.Dispatchers
{
    public interface IDispatcher
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}