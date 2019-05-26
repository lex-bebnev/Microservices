using System.Threading.Tasks;
using Inspe.Common.Mongo;
using STM.Services.Federations.Domain;

namespace STM.Services.Federations.Repositories
{
    public class FederationsRepository: IFederationsRepository
    {
        private IMongoRepository<SportFederation> _repository;

        public FederationsRepository(IMongoRepository<SportFederation> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(SportFederation federation) 
            => await _repository.AddAsync(federation);

        public async Task UpdateAsync(SportFederation federation) 
            => await _repository.UpdateAsync(federation);
    }
}