using System.Threading.Tasks;
using STM.Services.Federations.Domain;

namespace STM.Services.Federations.Repositories
{
    public interface IFederationsRepository
    {
        Task AddAsync(SportFederation federation);
        Task UpdateAsync(SportFederation federation);
    }
}