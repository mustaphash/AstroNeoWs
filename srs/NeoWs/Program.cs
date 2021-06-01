using External.NASA.Queries.Interfaces;
using External.NASA.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NeoWs
{
    class Program
    {
        static async Task Main(string[] args)
        {

            IGetAsteroidQuery nasaService = new GetAsteroidQuery();
            var asteroids = await nasaService.ExecuteAsync();

            Console.WriteLine(asteroids.name);
            Console.WriteLine($"{asteroids.close_approach_data.Last().miss_distance.kilometers} km.");
        }
    }
}