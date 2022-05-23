using Weather.BusinessLogic.Extensions;
using Weather.BusinessLogic.Helpers.Interfaces;
using Weather.BusinessLogic.Models;
using Weather.BusinessLogic.Services.Interfaces;
using Weather.Database;
using Weather.Database.Entities;

namespace Weather.BusinessLogic.Services.Implementations
{
    internal class WeatherService : IWeatherService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAccuWeatherHelper accuWeatherHelper;
        public WeatherService(IUnitOfWork unitOfWork, IAccuWeatherHelper accuWeatherHelper)
        {
            this.unitOfWork = unitOfWork;
            this.accuWeatherHelper = accuWeatherHelper;
        }

        public async Task<IEnumerable<WeatherModel>> GetWeatherAsync(int locationId, int days)
        {
            //TODO:add options
            var now = DateTime.UtcNow.Date;
            var date = DateTime.UtcNow.AddHours(-4);

            var entities = await unitOfWork.Repository<WeatherEntity>()
                .GetAsync(x => x.LocationId == locationId && x.Created <= date);
            var items = entities.Where(x=>x.Date >= now && x.Date < now.AddDays(days));

            if (!items.Any())
            {
                var weatherItems = await accuWeatherHelper.GetAccuWeatherAsync(locationId);
            }


            return items.Select(x=>x.Map());
        }
    }
}
