using External.Nasa.Queries;
using External.Nasa.Queries.Interfaces;
using External.NASA.Queries.Interfaces;
using External.NASA.Services;
using Models.MarsRoverPhoto;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NeoWs
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            IGetAsteroidQuery nasaService = new GetAsteroidQuery();
            var asteroids = await nasaService.ExecuteAsync();

            IGetMarsWeatherQuery marsService = new GetMarsWeatherQuery();
            var mars = await marsService.ExecuteAsync();

            IGetMarsPhotoQuery marsPhotos = new GetMarsPhotoQuery();
            MarsPhotos photos = await marsPhotos.ExecuteAsync();
            foreach (var photo in photos.photos)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(photo.img_src), $@"D:\Images\MarsRover.jpg");
                }
            }
           

            Console.WriteLine(photos.photos.Count);
            Console.WriteLine($"{mars.validity_checks.sol_hours_required}");
            Console.WriteLine($"Name: {asteroids.name}");
            Console.WriteLine($"{asteroids.close_approach_data.Last().miss_distance.kilometers} km.");
        }
    }
}