using System.Threading.Tasks;

namespace Inspe.Common.Mongo
{
    public interface IMongoDbSeeder
    {
        Task SeedAsync();
    }
}