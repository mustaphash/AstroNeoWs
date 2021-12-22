using Models.MarsRoverPhoto;
using System.Threading.Tasks;

namespace External.Nasa.Commands.Interfaces
{
    public interface IFindMarsPhotosCommand
    {
        Task ExecuteAsync(MarsPhotos photo1, string folder);
    }
}
