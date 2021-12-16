using External.NASA.Queries.Interfaces;
using Models.Asteroids;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace External.NASA.Services
{
    public class GetAsteroidQuery : IGetAsteroidQuery
    {
        private readonly Context _httpClientContext;

        public GetAsteroidQuery()
            : this(new Context())
        {
        }

        public GetAsteroidQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<Asteroid> ExecuteAsync()
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://api.nasa.gov/neo/rest/v1/neo/3542519?api_key=8GRDknKoE72VOtBpAjH4nOUFaVcy2iv82C1JQoMK");
            string content = await response.Content.ReadAsStringAsync();

            Asteroid asteroids = JsonConvert.DeserializeObject<Asteroid>(content);

            return asteroids;
        }
    }
}
