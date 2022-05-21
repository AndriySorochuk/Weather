
using Weather.BusinessLogic.Models;

namespace Weather.BusinessLogic.Services.Interfaces
{
    public interface ILocationsService
    {
        Task<IEnumerable<LocationModel>> SearchAsync(string locationName);
    }
}
