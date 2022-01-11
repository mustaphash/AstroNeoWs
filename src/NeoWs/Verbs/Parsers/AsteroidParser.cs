using External.Nasa.Commands.Interfaces;
using External.NASA.Queries.Interfaces;
using External.NASA.Services;
using System.Threading.Tasks;

namespace NeoWs.Verbs.Parsers
{
    public class AsteroidParser
    {
        public async Task<int> ParseAstro(AsteroidVerb info)
        {
            IGetAsteroidQuery astro = new GetAsteroidQuery();
            var asteroid = await astro.ExecuteAsync();
            System.Console.WriteLine($"ID: {asteroid.id}");
            System.Console.WriteLine($"Name: {asteroid.name}");
            System.Console.WriteLine($"URL: {asteroid.nasa_jpl_url}");
            System.Console.WriteLine($"Date: {asteroid.orbital_data.first_observation_date}");

            return 0;
        }
    }
}
