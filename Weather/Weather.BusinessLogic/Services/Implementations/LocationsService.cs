using System;
using Weather.BusinessLogic.Models;
using Weather.BusinessLogic.Services.Interfaces;

namespace Weather.BusinessLogic.Services.Implementations
{
    internal class LocationsService : ILocationsService
    {
        public LocationsService()
        {

        }

        public Task<IEnumerable<LocationModel>> SearchAsync(string locationName)
        {
            throw new NotImplementedException();
        }
    }
}
