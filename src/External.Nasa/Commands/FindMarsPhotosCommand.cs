using External.Nasa.Commands.Interfaces;
using Models.MarsRoverPhoto;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Nasa.Commands
{
    public class FindMarsPhotosCommand : IFindMarsPhotosCommand
    {
        string uniqueName = Guid.NewGuid().ToString();
        public Task<MarsPhotos> ExecuteAsync(MarsPhotos photo,string folder)
        {
            IGetMarsPhotoQuery marsPhotos = new GetMarsPhotoQuery();
            MarsPhotos photos = await marsPhotos.ExecuteAsync();
            foreach (var photo in photos.photos)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(photo.img_src), $@"D:\Images\MarsRover.jpg");
                }
            }
            return Task.FromResult(photo);
        }
    }
}
