using Models.Asteroids;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Nasa.Commands.Interfaces
{
    public class FindAsteroidInfoCommand : IFindAsteroidInfoCommand
    {
        public Task ExecuteAsync(Asteroid asteroids, string info)
        {
            using (WebClient client = new WebClient())
            {
                client.OpenWrite(asteroids.neo_reference_id);
            }

            return Task.FromResult(asteroids);
        }
    }
}
