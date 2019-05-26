using System.Threading.Tasks;
using Inspe.Common.Types;

namespace Inspe.Common.Dispatchers
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}