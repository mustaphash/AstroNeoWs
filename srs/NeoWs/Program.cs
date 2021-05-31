using Models.Asteroids;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeoWs
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://api.nasa.gov/neo/rest/v1/neo/3542519?api_key=8GRDknKoE72VOtBpAjH4nOUFaVcy2iv82C1JQoMK");
            string content = await response.Content.ReadAsStringAsync();

            Asteroid asteroids = JsonConvert.DeserializeObject<Asteroid>(content);

            Console.WriteLine(asteroids.name);
            Console.WriteLine($"{asteroids.close_approach_data.Last().miss_distance.kilometers} km.");
        }
    }
}
