using External.Nasa.Queries;
using External.Nasa.Queries.Interfaces;
using System;
using System.Threading.Tasks;

namespace NeoWs.Verbs.Parsers
{
    public class MarsWeatherParser
    {
        public async Task<int> ParseWeather(MarsWeatherVerb weather)
        {
            IGetMarsWeatherQuery marsWeather = new GetMarsWeatherQuery();
            var mars = await marsWeather.ExecuteAsync();
            Console.WriteLine(mars.validity_checks.sol_hours_required);

            return 0;
        }
    }
}
