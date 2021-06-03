using System.Threading.Tasks;

namespace External.Nasa.Queries.Interfaces
{
    public interface IGetMarsWeatherQuery
    {
        Task<MarsWeathers> ExecuteAsync();
    }
}
