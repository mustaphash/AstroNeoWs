using Models.MarsWeather;
using System.Threading.Tasks;

namespace External.Nasa.Queries.Interfaces
{
    public interface IGetMarsWeatherQuery
    {
        Task<MarsWeather> ExecuteAsync();
    }
}
