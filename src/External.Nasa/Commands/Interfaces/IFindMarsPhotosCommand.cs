using Models.MarsRoverPhoto;
using System.Threading.Tasks;

namespace External.Nasa.Commands.Interfaces
{
    public interface IFindMarsPhotosCommand
    {
         Task<MarsPhotos> ExecuteAsync(MarsPhotos photo, string folder)
    }
}
