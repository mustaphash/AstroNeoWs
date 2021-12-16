using Models.MarsRoverPhoto;
using System.Threading.Tasks;

namespace External.Nasa.Queries.Interfaces
{
    public interface IGetMarsPhotoQuery
    {
        Task<MarsPhotos> ExecuteAsync();
    }
}
