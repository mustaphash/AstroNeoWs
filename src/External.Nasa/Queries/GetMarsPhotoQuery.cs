using External.Nasa.Queries.Interfaces;
using External.NASA;
using Models.MarsRoverPhoto;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace External.Nasa.Queries
{
    public class GetMarsPhotoQuery : IGetMarsPhotoQuery
    {
        private readonly Context _httpClientContext;

        public GetMarsPhotoQuery()
            : this(new Context())
        {

        }
        public GetMarsPhotoQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<MarsPhotos> ExecuteAsync()
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=DEMO_KEY");
            string content = await response.Content.ReadAsStringAsync();

            MarsPhotos photo = JsonConvert.DeserializeObject<MarsPhotos>(content);
            return photo;
        }
    }
}
