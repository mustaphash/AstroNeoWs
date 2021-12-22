using External.Nasa.Commands;
using External.Nasa.Commands.Interfaces;
using External.Nasa.Queries;
using External.Nasa.Queries.Interfaces;
using Models.MarsRoverPhoto;
using System.Threading.Tasks;

namespace NeoWs.Verbs.Parsers
{
    public class MarsPhotoParser
    {
        public async Task<int> PhotoParse(MarsPhotoVerb marsPhoto)
        {
            IGetMarsPhotoQuery marsPhotos = new GetMarsPhotoQuery();
            MarsPhotos photos = await marsPhotos.ExecuteAsync();

            IFindMarsPhotosCommand findMars = new FindMarsPhotosCommand();
            await findMars.ExecuteAsync(photos, marsPhoto.Folder);

            return 0;
        }
    }
    
}
