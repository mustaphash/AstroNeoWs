using Models.Asteroids;
using System.Threading.Tasks;

namespace External.NASA.Queries.Interfaces
{
    public interface IGetAsteroidQuery
    {
        Task<Asteroid> ExecuteAsync();
    }
}
