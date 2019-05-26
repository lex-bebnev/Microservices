using System;
using System.Threading.Tasks;
using Inspe.Common.Types;
using STM.Api.Models.SportsFederations;
using STM.Api.Query;

namespace STM.Api.Services
{
    public interface ISportsFederationService
    {
        /*[AllowAnyStatusCode]
        [Get("sports-federation/{id}")]
        Task<Customer> GetAsync([Path] Guid id);  */

        // [AllowAnyStatusCode]
        // [Get("sports-federation")]
        Task<PagedResult<SportFederation>> BrowseAsync(BrowseSportsFederations query);
    }
}