using System.Threading.Tasks;

namespace Inspe.Common
{
    public interface IInitializer
    {
        Task InitializeAsync();
    }
}