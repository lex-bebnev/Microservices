using System.Threading.Tasks;
using Inspe.Common.Messages;

namespace Inspe.Common.Dispatchers
{
    public interface ICommandDispatcher
    {
         Task SendAsync<T>(T command) where T : ICommand;
    }
}