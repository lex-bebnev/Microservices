using System.Threading.Tasks;
using Inspe.Common.Types;

namespace Inspe.Common.Handlers
{
    public interface IQueryHandler<TQuery,TResult> where TQuery : IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}