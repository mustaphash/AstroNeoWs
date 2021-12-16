using External.Nasa.Queries.Interfaces;
using External.NASA;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Models.MarsWeather;

namespace External.Nasa.Queries
{
    public class GetMarsWeatherQuery : IGetMarsWeatherQuery
    {
        private readonly Context _httpClientContext;

        public GetMarsWeatherQuery()
            : this(new Context())
        {
        }

        public GetMarsWeatherQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<MarsWeather> ExecuteAsync()
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://api.nasa.gov/insight_weather/?api_key=DEMO_KEY&feedtype=json&ver=1.0");
            string content = await response.Content.ReadAsStringAsync();

            MarsWeather marsWeather = JsonConvert.DeserializeObject<MarsWeather>(content);

            return marsWeather;
        }
    }
}
