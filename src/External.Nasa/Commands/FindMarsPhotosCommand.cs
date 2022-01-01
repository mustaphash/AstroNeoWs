using External.Nasa.Commands.Interfaces;
using Models.MarsRoverPhoto;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Nasa.Commands
{
    public class FindMarsPhotosCommand : IFindMarsPhotosCommand
    {
        public  Task ExecuteAsync(MarsPhotos photo1,string folder)
        {
            string uniqueName = Guid.NewGuid().ToString();

            foreach (var photo in photo1.photos)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(photo.img_src), $@"{folder}\{uniqueName}.jpg");
                }
            }
            return Task.FromResult(photo1);
        }
    }
}
