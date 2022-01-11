using Models.Asteroids;
using System.Threading.Tasks;

namespace External.Nasa.Commands.Interfaces
{
    public interface IFindAsteroidInfoCommand
    {
        Task ExecuteAsync(Asteroid asteroids, string info);
    }
}
