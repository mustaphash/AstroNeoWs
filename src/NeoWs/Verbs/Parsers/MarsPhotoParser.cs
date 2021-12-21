using External.Nasa.Queries;
using External.Nasa.Queries.Interfaces;
using Models.MarsRoverPhoto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeoWs.Verbs.Parsers
{
    public class MarsPhotoParser
    {
        string uniqueName = Guid.NewGuid().ToString();
        public async Task<MarsPhotos> ExecuteAsync(MarsPhotos photoMars, string folder)
        {
            IGetMarsPhotoQuery marsPhotos = new GetMarsPhotoQuery();
            MarsPhotos photos = await marsPhotos.ExecuteAsync();
            foreach (var photo in photoMars.photos)
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
}
