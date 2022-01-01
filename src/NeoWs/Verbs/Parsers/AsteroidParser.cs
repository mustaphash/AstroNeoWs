using External.NASA.Queries.Interfaces;
using External.NASA.Services;
using System.Threading.Tasks;

namespace NeoWs.Verbs.Parsers
{
    public class AsteroidParser
    {
        public async Task<string> ParseAstro()
        {
            IGetAsteroidQuery astro = new GetAsteroidQuery();
            var asteroid = await astro.ExecuteAsync();
           
            return asteroid.name;
        }
    }
}
